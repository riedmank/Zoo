using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class AmericanAlligator : Crocodilia
    {
        public override int numTeeth { get; set; }

        /// <summary>
        /// Alligator noise method
        /// </summary>
        /// <returns>Returns a string</returns>
        public override string Sound()
        {
            return "Alligator noises";
        }
    }
}
