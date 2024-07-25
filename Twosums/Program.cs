using System;

public class Solution
{
    public int[] TwoSum(int[] nums, int target) 
    {
        // Dictionary to store the index of the elements we have seen
        var indexMap = new Dictionary<int, int>();

        // Iterate through the array
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            
            // Check if the complement exists in the dictionary
            if (indexMap.TryGetValue(complement, out int complementIndex))
            {
                // Return the indices of the two numbers
                return new int[] { complementIndex, i };
            }
            
            // Add the current number and its index to the dictionary
            indexMap[nums[i]] = i;
        }

        // Return an empty array if no solution is found
        return new int[] { };
    }
}

class Program
{
    static void Main()
    {
        // Example usage
        Solution solution = new Solution();
        
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        
        int[] result = solution.TwoSum(nums, target);
        
        Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");
    }
}

