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
    public class Person : ModelBaseObject
    {
        /// <summary>
        /// Die ID der Person
        /// </summary>
        public string PersonID
        {
            get; set;
        }

        public string Vorname
        {
            get; set;
        }

        public string Nachname
        {
            get; set;
        }
    }
}
