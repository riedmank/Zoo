using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class NileCrocodile : Crocodilia
    {
        public override int numTeeth { get; set; }

        public override string Sound()
        {
            return "Crocodile noises";
        }

        public override int SubmergeTime()
        {
            return 45;
        }
    }
}
