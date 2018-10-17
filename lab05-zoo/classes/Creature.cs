using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_zoo.classes
{
    public abstract class Creature
    {
        /// <summary>
        /// properties
        /// </summary>
        public abstract bool LiveForever { get; set; }

        public abstract bool HaveWings { get; set; }

        /// <summary>
        /// methods
        /// </summary>
        /// <returns></returns>
        public abstract string MagicalPower();

        public int HowManySpouses()
        {
            return 2;
        }
    }
}
