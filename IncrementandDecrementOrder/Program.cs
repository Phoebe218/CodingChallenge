using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Increment and Decrement Order

            int value = 1;

            // Increment operators
            value++;
            Console.WriteLine("First: " + value);  // Output: 2

            Console.WriteLine("Second: " + value++);  // Output: 2 (value is printed, then incremented)
            Console.WriteLine("Third: " + value);     // Output: 3 (value has been incremented)

            // Increment operator with prefix
            Console.WriteLine("First: " + (++value)); // Output: 4 (value is incremented, then printed)

            // Resetting value for the next example
            value = 1;

            // Increment operators with prefix and postfix
            ++value;
            value++;
            Console.WriteLine("First: " + value);     // Output: 3 (value is incremented twice)

        }
    }
}

