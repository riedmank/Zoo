using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    class NileCrocodile : Crocodilia, ICanLayEggs, ICanDig
    {
        public override int numTeeth { get; set; }
        public bool CanLayEggs { get; set; }
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
        /// Interface method that lays eggs
        /// </summary>
        /// <returns>Returns number of eggs laid</returns>
        public int LayEggs()
        {
            return 8;
        }

        /// <summary>
        /// Sound a crocodile makes
        /// </summary>
        /// <returns>Returns a string</returns>
        public override string Sound()
        {
            return "Crocodile noises";
        }
    }
}
