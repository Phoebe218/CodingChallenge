using System;

class Program
{
    static void Main()
    {
        // Display the range of signed integral types
        Console.WriteLine("Signed integral type:");
        Console.WriteLine($"sbyte : {sbyte.MinValue} to {sbyte.MaxValue}");
        Console.WriteLine($"short : {short.MinValue} to {short.MaxValue}");
        Console.WriteLine($"int : {int.MinValue} to {int.MaxValue}");
        Console.WriteLine($"long : {long.MinValue} to {long.MaxValue}");
    }
}

