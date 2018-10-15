using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class SpectacledCaiman : Crocodilia
    {
        public override int numTeeth { get; set; }

        public override string Sound()
        {
            return "Caiman noises";
        }

        public override int SubmergeTime()
        {
            return 25;
        }
    }
}
