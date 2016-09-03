/*
 * Copyright André Kirst
 * 2016 - 2016
 * School
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebApi.Models
{
    public class ModelBaseObject
    {
        /// <summary>
        /// Die ID des MongoDB-Objektes
        /// </summary>
        [BsonId]
        public ObjectId ID
        {
            get; set;
        }

        /// <summary>
        /// Das Datum, wann das Objekt erschaffen wurde
        /// </summary>
        public DateTime CreatedAt
        {
            get; set;
        }

        /// <summary>
        /// Das Datum, wann das Objekt zuletzt verändert wurde
        /// </summary>
        [BsonIgnoreIfNull]
        public DateTime? ModifiedAt
        {
            get; set;
        }
    }
}
