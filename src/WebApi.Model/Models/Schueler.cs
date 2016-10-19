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
    public class Schueler : Person
    {
        public Schueler()
        {
        }

        /// <summary>
        /// Die ID des Schülers
        /// </summary>
        public string SchuelerID
        {
            get; set;
        }
    }
}
