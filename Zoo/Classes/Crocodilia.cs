using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Crocodilia : Animal
    {
        public override bool canSwim { get; set; }
        public override bool canFly { get; set; }
        public virtual int numTeeth { get; set; }

        public override string Sleep()
        {
            return "zzz";
        }

        public override string Eat()
        {
            return "nom nom nom"; 
        }

        public virtual string Sound()
        {
            return "reptile noises";
        }

        public virtual int SubmergeTime()
        {
            return 20;
        }
    }
}
