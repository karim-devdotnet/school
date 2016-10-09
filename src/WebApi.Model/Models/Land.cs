/*
 * Copyright André Kirst
 * 2016 - 2016
 * School
*/

namespace WebApi.Models
{
    /// <summary>
    /// Das Objekt Land
    /// </summary>
    public class Land : ModelBaseObject
    {
        public Land()
        {
        }

        /// <summary>
        /// Der Name des Landes
        /// </summary>
        public string Name
        {
            get; set;
        }
    }
}