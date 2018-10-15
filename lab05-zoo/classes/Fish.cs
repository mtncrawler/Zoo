using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_zoo.classes
{
    abstract class Fish
    {
        public virtual int NumberOfGills { get; set; }

        public virtual string MyUniqueness()
        {
            return "I can swim.";
        }
    }
}
