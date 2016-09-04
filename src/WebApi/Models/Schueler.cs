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
    public class Schueler : ModelBaseObject
    {
        public Schueler()
        {
        }

        public string SchuelerID
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
