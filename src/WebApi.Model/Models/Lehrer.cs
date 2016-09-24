/*
 * Copyright André Kirst
 * 2016 - 2016
 * School
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Lehrer : Person
    {
        /// <summary>
        /// Die ID des Lehrers
        /// </summary>
        public string LehrerID
        {
            get; set;
        }
    }
}
