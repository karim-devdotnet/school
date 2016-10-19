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
    public class Adresse : ModelBaseObject
    {
        public const string C_LAND_DEUTSCHLAND = "EUROPA_DEUTSCHLAND";

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
        /// Das Bundesland
        /// </summary>
        public Bundesland Bundesland
        {
            get; set;
        }

        /// <summary>
        /// Gibt true zurück, wenn alle Pflichtfelder gefüllt sind
        /// </summary>
        public bool IstGueltig
        {
            get
            {
                return
                    !String.IsNullOrEmpty(Ort) &&
                    !String.IsNullOrEmpty(Strasse) &&
                    IstPostleitzahlGueltig &&
                    !String.IsNullOrEmpty(Hausnummer) &&
                    IstLandGueltig &&
                    IstBundeslandGueltig;
            }
        }

        /// <summary>
        /// Gibt true zurück, wenn es für das Land die korrekte Postleitzahl angegeben wurde. Unterstützt wird derzeit nur Deutschland
        /// </summary>
        public bool IstPostleitzahlGueltig
        {
            get
            {
                return !String.IsNullOrEmpty(Postleitzahl) && IstLandGueltig && Postleitzahl.Length == 5;
            }
        }

        public bool IstLandGueltig
        {
            get
            {
                return Bundesland != null && Bundesland.Land != null && Bundesland.Land.Ident == C_LAND_DEUTSCHLAND;
            }
        }

        public bool IstBundeslandGueltig
        {
            get
            {
                return Bundesland != null;
            }
        }
    }
}
