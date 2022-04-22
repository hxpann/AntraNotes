using System;

namespace _02UnderstandingTypes
{
    public class FizzBuzz
    {
        public static void FizzBuzz100()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                    Console.Write("FizzBuzz");
                else if (i % 3 == 0)
                    Console.Write("Fizz");
                else if (i % 5 == 0)
                    Console.Write("Buzz");
                else
                    Console.Write(i);

                if (i < 100)
                    Console.Write(",");
                if (i % 15 == 0)
                    Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
