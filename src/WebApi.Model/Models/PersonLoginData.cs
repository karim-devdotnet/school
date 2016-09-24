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
    /// Anmeldedaten für eine Person
    /// </summary>
    public class PersonLoginData
    {
        /// <summary>
        /// Der Ident des Logins. Dies wird durch eine E-Mailadresse identifiziert
        /// </summary>
        public string LoginUserIdent
        {
            get; set;
        }

        /// <summary>
        /// Verschlüsseltes Passwort
        /// </summary>
        public string Password
        {
            get; set;
        }

        /// <summary>
        /// Datum der letzten Anmeldung
        /// </summary>
        public DateTime? LastLogin
        {
            get; set;
        }

        /// <summary>
        /// Der Pfad zu einem Bild für den Avatar
        /// </summary>
        public string AvatarImagePath
        {
            get; set;
        }
    }
}
