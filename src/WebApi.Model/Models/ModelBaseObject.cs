/*
 * Copyright André Kirst
 * 2016 - 2016
 * School
*/
using MongoDB.Bson;
using System;

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
        /// Der fachliche Identifizierer des Objektes
        /// </summary>
        public string Ident
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
        /// Die Person, die das Objekt erstellt hat
        /// </summary>
        public Person CreatedBy
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

        /// <summary>
        /// Die Person, die das Objekt verändert hat
        /// </summary>
        public Person ModifiedBy
        {
            get; set;
        }
    }
}
