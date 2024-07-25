using System;

class Solution
{
    // Method to calculate the number of jumps needed
    public int CalculateJumps(int X, int Y, int D)
    {
        int jumpProgress = X;
        int count = 0;

        // Loop until jumpProgress reaches or exceeds Y
        while (jumpProgress < Y)
        {
            jumpProgress += D;
            count++;
        }

        return count;
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the Solution class
        Solution solution = new Solution();

        // Example values for X, Y, and D
        int X = 10;
        int Y = 85;
        int D = 30;

        // Calculate the number of jumps and display the result
        int jumps = solution.CalculateJumps(X, Y, D);
        Console.WriteLine($"Number of jumps needed: {jumps}");
    }
}

