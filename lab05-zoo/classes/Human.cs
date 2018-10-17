using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_zoo.classes
{
    public abstract class Human
    {
        /// <summary>
        /// properties
        /// </summary>
        public string Name { get; set; }
        
        public virtual int NumberOfBeatingHearts { get; set; }

        /// <summary>
        /// methods
        /// </summary>
        /// <returns></returns>
        public abstract string MyMotto();

        public virtual string GoalInLife()
        {
            return "I must ensure my survival.";
        }
    }
}
