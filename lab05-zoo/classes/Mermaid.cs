using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_zoo.classes
{
    public class Mermaid : Fish
    {
        public override string MyUniqueness()
        {
            return base.MyUniqueness() + "I have arms.";
        }
    }
}
