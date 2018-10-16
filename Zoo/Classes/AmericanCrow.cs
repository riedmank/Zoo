using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    class AmericanCrow : Corvidae, ICanLayEggs
    {
        public override string colorType { get; set; }
        public bool CanLayEggs { get; set; }

        /// <summary>
        /// Interface method that lays eggs
        /// </summary>
        /// <returns>Returns number of eggs laid</returns>
        public int LayEggs()
        {
            return 8;
        }

        /// <summary>
        /// Sound a crow makes
        /// </summary>
        /// <returns>Returns a string</returns>
        public override string Sound()
        {
            return "Crow caw caw";
        }
    }
}
