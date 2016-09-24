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
    /// Klasse für eine Adrese
    /// </summary>
    public class Adresse
    {
        /// <summary>
        /// Der Ort
        /// </summary>
        public string Ort
        {
            get; set;
        }

        /// <summary>
        /// Die Straße
        /// </summary>
        public string Strasse
        {
            get; set;
        }

        /// <summary>
        /// Die Postleitzahl
        /// </summary>
        public string Postleitzahl
        {
            get; set;
        }

        /// <summary>
        /// Die Hausnummer
        /// </summary>
        public string Hausnummer
        {
            get; set;
        }

        /// <summary>
        /// Das Land
        /// </summary>
        public string Land
        {
            get; set;
        }

        /// <summary>
        /// Das Bundesland
        /// </summary>
        public string Bundesland
        {
            get; set;
        }
    }
}
