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
    public class SchoolContext
    {
        public SchoolContext(string connectionString)
        {
            ConnectionString = connectionString;
        }

        private static SchoolContext __instance = null;
        public static SchoolContext Instance(string connectionString)
        {
            if(__instance == null)
            {
                __instance = new SchoolContext(connectionString);
            }
            return __instance;
        }
        public static SchoolContext Instance()
        {
            if(__instance == null)
            {
                throw new Exception("Der SchoolContext muss mit Instance(string) aufgerufen werden");
            }
            return __instance;
        }

        public string ConnectionString
        {
            get; set;
        }

        public MongoClient GetConnection()
        {
            MongoClient client = new MongoClient(ConnectionString);
            return client;
        }
    }
}
