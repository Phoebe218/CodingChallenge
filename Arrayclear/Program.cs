using System;

class Program
{
    static void Main()
    {
        // Array of pallets
        string[] pallets = { "Z12", "W11", "Z14", "W13" };

        // Display the initial state of the array
        Console.WriteLine($"Before: {pallets[0].ToLower()}");

        // Clear the first two elements of the array
        Array.Clear(pallets, 0, 2);

        // Display the state of the first element after clearing
        if (pallets[0] != null)
        {
            Console.WriteLine($"After: {pallets[0].ToLower()}");
        }
        else
        {
            Console.WriteLine($"After: {pallets[0]} (null)");
        }

        // Display the entire array after clearing
        Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }
    }
}

