using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class AmericanCrow : Corvidae
    {
        public override string colorType { get; set; }

        public override string Sound()
        {
            return "Crow caw caw";
        }

        public override int FlyingRange()
        {
            return 35;
        }
    }
}
