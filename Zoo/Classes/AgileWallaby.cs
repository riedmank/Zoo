using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    class AgileWallaby : Macropus, ICanDig
    {
        public override string SubGenus { get; set; }
        public int NumClaws { get; set; }

        /// <summary>
        /// Method that has an animal dig a hole
        /// </summary>
        /// <returns>Returns a string saying they dug a hole</returns>
        public string DigAHole()
        {
            return "I dug a hole";
        }

        /// <summary>
        /// Hop Method
        /// </summary>
        /// <returns>Returns a string</returns>
        public override string Hop()
        {
            return "Wallaby Hop Hop Hop";
        }
    }
}
