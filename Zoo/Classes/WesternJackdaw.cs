using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class WesternJackdaw : Corvidae
    {
        public override string colorType { get; set; }

        public override string Sound()
        {
            return "Jackdaw caw caw";
        }

        public override int FlyingRange()
        {
            return 20;
        }
    }
}
