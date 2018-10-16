using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_zoo.classes
{
    public class Pegasus : Centaur
    {
        public override bool LiveForever { get; set; } = true;

        public override bool HaveWings { get; set; } = true;

        public override string MagicalPower()
        {
            return "I can fly at incredible speeds.";
        }
    }
}
