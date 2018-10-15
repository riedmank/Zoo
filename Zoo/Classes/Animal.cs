using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public abstract class Animal
    {
        public abstract bool canSwim { get; set; }
        public abstract bool canFly { get; set; }

        public abstract string Sleep();

        public abstract string Eat();
    }
}
