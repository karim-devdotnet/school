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
    public static class SchoolContext
    {
        public static string GetConnection()
        {
            return string.Empty;
            //MongoClient client = new MongoClient(Conn);
            //return client.GetServer();
        }
    }
}
