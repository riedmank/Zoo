using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public abstract class Animal
    {
        public abstract bool canSwim { get; set; }
        public abstract bool canFly { get; set; }

        /// <summary>
        /// Abstract Sleep Method
        /// </summary>
        /// <returns>Returns nothing because it is abstract</returns>
        public abstract string Sleep();

        /// <summary>
        /// Abstract Eat Method
        /// </summary>
        /// <returns>Returns nothing because it is abstract</returns>
        public abstract string Eat();
    }
}
