using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_zoo.interfaces
{
    interface ILive
    {
        /// <summary>
        /// property
        /// </summary>
        bool LiveForever { get; set; }

        /// <summary>
        /// method
        /// </summary>
        /// <returns>string</returns>
        string BirthPlace();
    }
}
