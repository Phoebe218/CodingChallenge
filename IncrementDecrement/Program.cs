using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Increment and Decrement

            int value = 1;
            value = value + 1;
            Console.WriteLine("First Increment: " + value);

            value += 1;
            Console.WriteLine("Second Increment: " + value);

            value++;
            Console.WriteLine("Third Increment: " + value);

            value = value - 1;
            Console.WriteLine("First Decrement: " + value);

            value -= 1;
            Console.WriteLine("Second Decrement: " + value);

            value--;
            Console.WriteLine("Third Decrement: " + value);
        }
    }
}

