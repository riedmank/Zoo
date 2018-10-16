using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class NileCrocodile : Crocodilia
    {
        public override int numTeeth { get; set; }

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
