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
            return "caw caw";
        }

        public virtual int FlyingRange()
        {
            return 50;
        }
    }
}
