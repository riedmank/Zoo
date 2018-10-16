using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Interfaces
{
    interface ICanDig
    {
        int NumClaws { get; set; }

        string DigAHole();
    }
}
