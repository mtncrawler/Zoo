using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_zoo.interfaces
{
    interface IFly
    {
        bool HaveWings { get; set; }

        string FlightCapability();
    }
}
