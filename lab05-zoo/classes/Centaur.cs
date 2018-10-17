using lab05_zoo.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_zoo.classes
{
    public class Centaur : Unicorn, ILive
    {
        /// <summary>
        /// properties
        /// </summary>
        public string Name { get; set; }

        public override bool LiveForever { get; set; } = true;

        public override bool HaveWings { get; set; } = false;

        /// <summary>
        /// methods
        /// </summary>
        /// <returns></returns>
        public new string BirthPlace()
        {
            return "I was born in Greenland.";
        }

        public override string MagicalPower()
        {
            return "I have superior strength and speed.";
        }
    }
}
