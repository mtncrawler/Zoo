using System;
using lab05_zoo.classes;

namespace lab05_zoo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Vampire vamp1 = new Vampire();

            //Console.WriteLine(vamp1.MyMotto());
            //Console.WriteLine(vamp1.GoalInLife());

            Mermaid merm = new Mermaid();

            Console.WriteLine(merm.MyUniqueness());

            Unicorn uni = new Unicorn();

            Console.WriteLine(uni.HowManySpouses());


        }
    }
}
