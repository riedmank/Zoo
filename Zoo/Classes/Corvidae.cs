using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Corvidae : Animal
    {
        public override bool canSwim { get; set; }
        public override bool canFly { get; set; }
        public virtual string colorType { get; set; }

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

        /// <summary>
        /// Virtual method of the sound the animal makes
        /// </summary>
        /// <returns>Returns a string</returns>
        public virtual string Sound()
        {
            return "caw caw";
        }

        /// <summary>
        /// Virtual method of the range of the animal
        /// </summary>
        /// <returns>Returns an integer</returns>
        public virtual int FlyingRange()
        {
            return 50;
        }
    }
}
