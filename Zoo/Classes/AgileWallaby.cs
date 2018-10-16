using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class AgileWallaby : Macropus
    {
        public override string SubGenus { get; set; }

        public override string Hop()
        {
            return "Hop Hop Hop";
        }
    }
}
