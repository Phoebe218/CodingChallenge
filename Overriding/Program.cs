using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using Random to generate dice rolls

            Random dice = new Random();

            // Roll 1: Generate a random number between int.MinValue and int.MaxValue
            int roll1 = dice.Next();
            Console.WriteLine($"First roll: {roll1}");

            // Roll 2: Generate a random number between 0 and 100
            int roll2 = dice.Next(101);
            Console.WriteLine($"Second roll: {roll2}");

            // Roll 3: Generate a random number between 50 and 100
            int roll3 = dice.Next(50, 101);
            Console.WriteLine($"Third roll: {roll3}");
        }
    }
}

