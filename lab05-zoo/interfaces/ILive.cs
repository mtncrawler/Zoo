using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_zoo.interfaces
{
    interface ILive
    {
        bool LiveForever { get; set; }

        string BirthPlace();
    }
}
