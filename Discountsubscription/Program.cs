using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int daysUntilExpiration = random.Next(1, 13); // Generates a number between 1 and 12 inclusive
        int discountPercentage = 0;

        if (daysUntilExpiration < 1)
        {
            Console.WriteLine("Your subscription has expired!");
        }
        else if (daysUntilExpiration == 1)
        {
            discountPercentage = 25;
            Console.WriteLine("Your subscription expires within a day!");
            Console.WriteLine($"Renew now and save {discountPercentage}%!");
        }
        else if (daysUntilExpiration <= 5)
        {
            discountPercentage = 15;
            Console.WriteLine($"Your subscription expires in: {daysUntilExpiration} days.");
            Console.WriteLine($"Renew now and save {discountPercentage}%!");
        }
        else if (daysUntilExpiration <= 7)
        {
            Console.WriteLine($"Your subscription expires in: {daysUntilExpiration} days.");
            Console.WriteLine("Your subscription will expire soon. Renew now!");
        }
    }
}

