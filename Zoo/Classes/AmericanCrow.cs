using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class AmericanCrow : Corvidae
    {
        public override string colorType { get; set; }

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
