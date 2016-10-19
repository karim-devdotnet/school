/*
 * Copyright André Kirst
 * 2016 - 2016
 * School
*/

namespace WebApi.Models
{
    public class Bundesland : ModelBaseObject
    {
        /// <summary>
        /// Der Konstruktor
        /// </summary>
        public Bundesland()
        {
        }

        /// <summary>
        /// Der Name des Landes
        /// </summary>
        public string Name
        {
            get; set;
        }

        public Land Land
        {
            get; set;
        }
    }
}