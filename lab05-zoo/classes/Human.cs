using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_zoo.classes
{
    abstract class Human
    {
        public string Name { get; set; }
        
        public virtual int NumberOfBeatingHearts { get; set; }

        public abstract string MyMotto();

        public virtual string GoalInLife()
        {
            return "I must ensure my survival.";
        }
    }
}
