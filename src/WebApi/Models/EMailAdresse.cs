using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
