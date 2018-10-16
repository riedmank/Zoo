using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Interfaces
{
    interface ICanLayEggs
    {
        bool CanLayEggs { get; set; }

        int LayEggs();
    }
}
