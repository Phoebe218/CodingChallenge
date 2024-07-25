using System;

class Program
{
    static void Main()
    {
        // Original string
        string s = "The quick brown fox jumps over the lazy dog";

        // Split the string into words
        string[] subs = s.Split(' ');

        // Process each word
        foreach (var sub in subs)
        {
            // Convert the word to a character array
            char[] value = sub.ToCharArray();
            
            // Reverse the character array
            Array.Reverse(value);
            
            // Join the reversed characters back into a string
            string result = String.Join("", value);
            
            // Print the reversed word
            Console.WriteLine(result);
        }
    }
}

