/*
 * Copyright André Kirst
 * 2016 - 2016
 * School
*/
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class ModelBaseObject
    {
        /// <summary>
        /// Ist die Id des Mongo-DB-Objektes
        /// </summary>
        public ObjectId Id
        {
            get; set;
        }

        /// <summary>
        /// Das Datum, bei dem das Objekt entstanden ist
        /// </summary>
        public DateTime CreatedAt
        {
            get; set;
        }

        /// <summary>
        /// Das Datum, bei dem das Objekt zuletzt geändert wurde
        /// </summary>
        public DateTime? ModifiedAt
        {
            get; set;
        }
    }
}
