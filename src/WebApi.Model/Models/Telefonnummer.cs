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
    /// <summary>
    /// Klasse für Telefonnummer
    /// </summary>
    public class Telefonnummer : ModelBaseObject
    {
        public string Nummer
        {
            get; set;
        }

        /// <summary>
        /// Ist die primäre Telefonnummer
        /// </summary>
        public bool IstPrimaer
        {
            get; set;
        }
    }
}
