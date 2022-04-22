using System;

class Class1
{
    public static void Main()
    {
        string color;
        string astrology_sign;
        int address_number;

        Console.WriteLine("Enter your favorite color: ");
        color = Console.ReadLine();

        Console.WriteLine("Enter your astrology sign: ");
        astrology_sign = Console.ReadLine();

        Console.WriteLine("Enter your street address number: ");
        address_number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Your hacker name is {color + astrology_sign + address_number}.");

    }
}

