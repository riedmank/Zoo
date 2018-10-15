﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class AmericanAlligator : Crocodilia
    {
        public override int numTeeth { get; set; }

        public override string Sound()
        {
            return "Alligator noises";
        }

        public override int SubmergeTime()
        {
            return 35;
        }
    }
}
