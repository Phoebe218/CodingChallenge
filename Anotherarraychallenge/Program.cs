using System;

class Program
{
    static void Main()
    {
        // Create a new Random instance for generating random values
        Random random = new Random();
        // Array to store the generated OrderIDs
        string[] orderIDs = new string[5];

        // Generate 5 random OrderIDs
        for (int i = 0; i < orderIDs.Length; i++)
        {
            // Generate a random prefix (A to E)
            int prefixValue = random.Next(55, 59); // ASCII values for 'A' to 'E' are 55 to 59
            string prefix = Convert.ToChar(prefixValue).ToString();
            // Generate a random three-digit suffix, ensuring it's zero-padded
            string suffix = random.Next(1, 1000).ToString("000");

            // Combine prefix and suffix to form the OrderID
            orderIDs[i] = prefix + suffix;
        }

        // Print all generated OrderIDs
        foreach (var orderID in orderIDs)
        {
            Console.WriteLine(orderID);
        }
    }
}

