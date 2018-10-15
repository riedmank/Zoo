using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public abstract class Animal
    {
        public abstract bool canSwim { get; set; }
        public abstract bool canFly { get; set; }

        public abstract void Sleep();

        public abstract void Eat();

        public abstract void Sound();
    }
}
