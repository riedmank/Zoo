using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class CommonRaven : Corvidae
    {
        public override string colorType { get; set; }

        /// <summary>
        /// Sound a raven makes
        /// </summary>
        /// <returns>Returns a string</returns>
        public override string Sound()
        {
            return "Raven caw caw";
        }
    }
}
