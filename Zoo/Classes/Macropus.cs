using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Macropus : Australosphenida
    {
        public virtual string SubGenus { get; set; }
        public override bool canSwim { get; set; }
        public override bool canFly { get; set; }

        /// <summary>
        /// Method overrides sleep method from Animal class
        /// </summary>
        /// <returns>Returns a string</returns>
        public override string Sleep()
        {
            return "zzz";
        }

        /// <summary>
        /// Method overrides eat method from Animal class
        /// </summary>
        /// <returns>Returns a string</returns>
        public override string Eat()
        {
            return "nom nom nom";
        }
    }
}
