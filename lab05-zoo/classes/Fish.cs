using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_zoo.classes
{
    public abstract class Fish
    {
        public virtual int NumberOfGills { get; set; }

        public virtual string MyUniqueness()
        {
            return "I can swim.";
        }

        public string WhatAboutChildren()
        {
            return "Hundreds!";
        }
    }
}
