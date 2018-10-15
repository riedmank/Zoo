using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class CommonRaven : Corvidae
    {
        public override string colorType { get; set; }

        public override string Sound()
        {
            return "Raven caw caw";
        }

        public override int FlyingRange()
        {
            return 45;
        }
    }
}
