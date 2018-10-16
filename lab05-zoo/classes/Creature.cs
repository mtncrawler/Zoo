using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_zoo.classes
{
    public abstract class Creature
    {
        public abstract bool LiveForever { get; set; }

        public abstract bool HaveWings { get; set; }

        public abstract string MagicalPower();
    }
}
