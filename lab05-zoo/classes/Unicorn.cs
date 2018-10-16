using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_zoo.classes
{
    class Unicorn : Creature
    {
        public int Age { get; set; }

        public override bool LiveForever { get; set; } = false;

        public override bool HaveWings { get; set; } = false;

        public override string MagicalPower()
        {
            return "Everything my horn touches turns to gold.";
        }


    }
}
