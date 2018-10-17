using System;
using lab05_zoo.classes;

namespace lab05_zoo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Vampire vampie = new Vampire { Name = "Drake", NumberOfBeatingHearts = 0 };
            Console.WriteLine($"Vampire: {vampie.MyMotto()}");
            Console.WriteLine($"Vampire: {vampie.GoalInLife()}");

            Mermaid merm = new Mermaid() { NumberOfGills = 4 };
            Console.WriteLine($"Mermaid: {merm.WhatAboutChildren()}");
            Console.WriteLine($"Mermaid: {merm.MyUniqueness()}");

            Unicorn uni = new Unicorn();
            Console.WriteLine($"Unicorn: {uni.MagicalPower()}");
            Console.WriteLine($"Unicorn: I have {uni.HowManySpouses()} spouses.");

            Centaur centie = new Centaur();
            Console.WriteLine($"Centaur: {centie.MagicalPower()}");

            Pegasus pegie = new Pegasus();
            Console.WriteLine($"Pegasus: {pegie.MagicalPower()}");


        }
    }
}
