/*
 * Copyright André Kirst
 * 2016 - 2016
 * School
*/
using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Base
{
    /// <summary>
    /// Diese Klasse dient dazu, das Auslesen und das Speichern der Objekte zu vereinheitlichen
    /// </summary>
    public class SchoolContext
    {
        #region Fields
        private static SchoolContext __instance = null;
        private MongoClient _mongoClient = null;
        #endregion

        /// <summary>
        /// Konstruktur mit dem ConnectionString und der Datenbank
        /// </summary>
        /// <param name="connectionString">Der ConnectionString zu der MongoDatenbank</param>
        /// <param name="databaseName">Die Datenbank</param>
        public SchoolContext(string connectionString, string databaseName)
        {
            ConnectionString = connectionString;
            DatabaseName = databaseName;
        }

        /// <summary>
        /// Erstellt eine Test-Datenbank
        /// </summary>
        /// <param name="databaseName"></param>
        public void CreateTestDatabase()
        {
            _mongoClient = new MongoClient(ConnectionString);

            if(_mongoClient != null && !string.IsNullOrEmpty(DatabaseName) && DatabaseName.StartsWith("Test_"))
            {
                IMongoDatabase db = _mongoClient.GetDatabase(DatabaseName);

                string testCollectionName = "_test_";

                List<BsonDocument> listOfCollection = db.ListCollections().ToList();
                BsonDocument testCollection = listOfCollection.FirstOrDefault(a => a.GetValue("name").AsString == testCollectionName);

                if(testCollection == null || !testCollection.Any())
                {
                    db.CreateCollection(testCollectionName);
                }
            }
        }

        /// <summary>
        /// Singleton-Instanz mit ConnectionString und der Name der Datenbank
        /// </summary>
        /// <param name="connectionString">Der ConnectionString zu der MongoDatenbank</param>
        /// <param name="databaseName">Die Datenbank</param>
        /// <returns></returns>
        public static SchoolContext Instance(string connectionString, string databaseName)
        {
            if(__instance == null)
            {
                __instance = new SchoolContext(connectionString, databaseName);
            }
            return __instance;
        }

        /// <summary>
        /// Singleton-Instanz
        /// </summary>
        /// <returns></returns>
        public static SchoolContext Instance()
        {
            if(__instance == null)
            {
                throw new Exception("Der SchoolContext muss mit Instance(string) aufgerufen werden");
            }
            return __instance;
        }

        /// <summary>
        /// Die Datenbank-Verbindung
        /// </summary>
        private IMongoDatabase DatabaseInstance
        {
            get
            {
                if(__instance == null)
                {
                    return null;
                }
                return __instance.GetConnection().GetDatabase(DatabaseName);
            }
        }

        /// <summary>
        /// Der ConnectionString
        /// </summary>
        public string ConnectionString
        {
            get; set;
        }

        /// <summary>
        /// Der Datenbankname
        /// </summary>
        public string DatabaseName
        {
            get; set;
        }

        /// <summary>
        /// Gibt die Verbindung zurück
        /// </summary>
        /// <returns></returns>
        private MongoClient GetConnection()
        {
            if(_mongoClient == null)
            {
                _mongoClient = new MongoClient(ConnectionString);
            }
            return _mongoClient;
        }

        /// <summary>
        /// Löscht die Datenbank
        /// </summary>
        /// <param name="name"></param>
        public void DropDatabase(string name)
        {
            if(_mongoClient != null && !String.IsNullOrEmpty(name) && name.StartsWith("Test_"))
            {
                _mongoClient.DropDatabase(name);
            }
        }

        /// <summary>
        /// Gibt eine IMongoCollection anhand des Names der Liste zurück
        /// </summary>
        /// <typeparam name="TDocument">Das Dokument, was ausgelesen werden soll</typeparam>
        /// <param name="name">Der Name der Collection. Wenn der Name null oder leer ist, wird der Name von TDcoument verwendet</param>
        /// <param name="settings"></param>
        /// <returns></returns>
        public IMongoCollection<TDocument> GetCollection<TDocument>(string name = null, MongoCollectionSettings settings = null)
            where TDocument : ModelBaseObject
        {
            string collectionName = name;
            if(String.IsNullOrEmpty(collectionName))
            {
                collectionName = typeof(TDocument).Name;
            }
            return DatabaseInstance.GetCollection<TDocument>(collectionName, settings);
        }

        /// <summary>
        /// Ein Item in einer Collection speichern
        /// </summary>
        /// <typeparam name="TDocument">Der Typ des Item</typeparam>
        /// <param name="document">Das Item</param>
        /// <param name="collection">Die Collection, in der das Item abgelegt werden soll</param>
        /// <returns></returns>
        public async Task<bool> SaveItem<TDocument>(TDocument document, IMongoCollection<TDocument> collection)
            where TDocument : ModelBaseObject
        {
            return await SaveItems(new List<TDocument>() { document }, collection);
        }

        /// <summary>
        /// Speichert mehrere Items in einer Collection
        /// </summary>
        /// <typeparam name="TDocument">Der Typ des Item</typeparam>
        /// <param name="documents">Die Items</param>
        /// <param name="collection">Die Collection, in der die Items abgelegt werden sollen</param>
        /// <returns></returns>
        public async Task<bool> SaveItems<TDocument>(List<TDocument> documents, IMongoCollection<TDocument> collection)
            where TDocument : ModelBaseObject
        {
            if(collection == null)
            {
                throw new NullReferenceException("Die Collection darf nicht NULL sein.");
            }

            List<TDocument> documentsToInsert = documents.Where(s => s.Id.Pid == 0).ToList();
            List<TDocument> documentsToUpdate = documents.Where(s => s.Id.Pid != 0).ToList();

            if(documentsToInsert.Any())
            {
                await collection.InsertManyAsync(documentsToInsert);
            }

            if(documentsToUpdate.Any())
            {
                await collection.InsertManyAsync(documentsToUpdate);
            }
            return true;
        }
    }
}
