/*
 * Copyright André Kirst
 * 2016 - 2016
 * School
*/
using System.Text.RegularExpressions;

namespace WebApi.Models
{
    /// <summary>
    /// Klasse für E-Mail-Adressen
    /// </summary>
    public class EMailAdresse
    {
        /// <summary>
        /// Die E-Mail-Adresse
        /// </summary>
        public string Adresse
        {
            get; set;
        }

        /// <summary>
        /// Ist die primäre E-Mail-Adresse
        /// </summary>
        public bool IstPrimaer
        {
            get; set;
        }

        public bool IstGueltig
        {
            get
            {
                return Regex.IsMatch(Adresse, @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
            }
        }
    }
}
