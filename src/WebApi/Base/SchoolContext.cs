/*
 * Copyright André Kirst
 * 2016 - 2016
 * School
*/
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        /// Gibt eine IMongoCollection anhand des Names der Liste zurück
        /// </summary>
        /// <typeparam name="TDocument">Das Dokument, was ausgelesen werden soll</typeparam>
        /// <param name="name"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        public IMongoCollection<TDocument> GetCollection<TDocument>(string name, MongoCollectionSettings settings = null)
        {
            return DatabaseInstance.GetCollection<TDocument>(name, settings);
        }
    }
}
