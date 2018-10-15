using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class WesternJackdaw : Corvidae
    {
        public override string colorType { get; set; }

        /// <summary>
        /// Sound a jackdaw makes
        /// </summary>
        /// <returns>Returns a string</returns>
        public override string Sound()
        {
            return "Jackdaw caw caw";
        }

        /// <summary>
        /// Range a jackdaw can fly
        /// </summary>
        /// <returns>Returns an integer</returns>
        public override int FlyingRange()
        {
            return 20;
        }
    }
}
