using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Example array
        int[] A = { -1, 2, -3, 4, 3, -2, 1 };

        // Call the method and display the result
        int uniqueAbsoluteCount = GetUniqueAbsoluteCount(A);
        Console.WriteLine($"Number of unique absolute values: {uniqueAbsoluteCount}");
    }

    // Method to get the number of unique absolute values
    static int GetUniqueAbsoluteCount(int[] A)
    {
        HashSet<int> abNumbers = new HashSet<int>();

        // Add absolute values to the HashSet
        foreach (int number in A)
        {
            abNumbers.Add(Math.Abs(number));
        }

        // Return the count of unique absolute values
        return abNumbers.Count;
    }
}

