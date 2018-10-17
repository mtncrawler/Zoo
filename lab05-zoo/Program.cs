using System;
using lab05_zoo.classes;

namespace lab05_zoo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my World!");

            Vampire vampie = new Vampire { Name = "Drake", NumberOfBeatingHearts = 0 };
            Console.WriteLine($"Vampire: {vampie.MyMotto()}");
            Console.WriteLine($"Vampire: {vampie.GoalInLife()}");
            Console.WriteLine();

            Mermaid merm = new Mermaid() { NumberOfGills = 4 };
            Console.WriteLine($"Mermaid: Number of children = {merm.WhatAboutChildren()}");
            Console.WriteLine($"Mermaid: {merm.MyUniqueness()}");
            Console.WriteLine();

            Unicorn uni = new Unicorn();
            Console.WriteLine($"Unicorn: {uni.MagicalPower()}");
            Console.WriteLine($"Unicorn: I have {uni.HowManySpouses()} spouses.");
            Console.WriteLine($"Unicorn by interface: {uni.FlightCapability()}");
            Console.WriteLine($"Unicorn by interface: {uni.BirthPlace()}");
            Console.WriteLine();

            Centaur centie = new Centaur();
            Console.WriteLine($"Centaur: {centie.MagicalPower()}");
            Console.WriteLine($"Centaur by interface: {centie.BirthPlace()}");
            Console.WriteLine();

            Pegasus pegie = new Pegasus();
            Console.WriteLine($"Pegasus: {pegie.MagicalPower()}");
            Console.WriteLine($"Pegasus by interface: {pegie.FlightCapability()}");
            Console.WriteLine($"Pegasus by interface: {pegie.BirthPlace()}");

        }
    }
}
