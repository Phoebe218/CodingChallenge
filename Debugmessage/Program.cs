using System; // Importing System namespace for basic functionalities
using System.Collections.Generic; // Importing for collection types if needed

class Program
{
    static void Main()
    {
        // Example debug message
        Console.WriteLine("This is a debug message");

        // Example of using the imported namespace
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        Console.WriteLine("Numbers in the list:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        // Additional logic or methods can be added here
    }
}

