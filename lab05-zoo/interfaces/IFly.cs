using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_zoo.interfaces
{
    interface IFly
    {
        /// <summary>
        /// property
        /// </summary>
        bool HaveWings { get; set; }

        /// <summary>
        /// method
        /// </summary>
        /// <returns>string</returns>
        string FlightCapability();
    }
}
