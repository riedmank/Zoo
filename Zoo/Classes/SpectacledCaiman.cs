using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class SpectacledCaiman : Crocodilia
    {
        public override int numTeeth { get; set; }

        /// <summary>
        /// Caiman noise method
        /// </summary>
        /// <returns>Returns a string</returns>
        public override string Sound()
        {
            return "Caiman noises";
        }

        /// <summary>
        /// Time a caiman can be submerged
        /// </summary>
        /// <returns>Returns an integer</returns>
        public override int SubmergeTime()
        {
            return 25;
        }
    }
}
