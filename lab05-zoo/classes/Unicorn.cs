using lab05_zoo.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_zoo.classes
{
    public class Unicorn : Creature, IFly, ILive
    {
        public int Age { get; set; }

        public override bool LiveForever { get; set; } = true;

        public override bool HaveWings { get; set; } = true;
        
        public override string MagicalPower()
        {
            return "Everything my horn touches turns to gold.";
        }

        public string FlightCapability()
        {
            return "I can fly short distances.";
        }
        
        public string BirthPlace()
        {
            return "I was born in Kansas.";
        }
    }
}
