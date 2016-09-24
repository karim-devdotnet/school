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
    public class Vormund : Person
    {
        /// <summary>
        /// Die ID des Vormundes
        /// </summary>
        public string VormundID
        {
            get; set;
        }

        public VormundArt Art
        {
            get; set;
        }
    }

    public enum VormundArt
    {
        Elternteil,
        Einrichtungsangestellter
    }
}
