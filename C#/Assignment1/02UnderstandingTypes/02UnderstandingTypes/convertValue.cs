using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02UnderstandingTypes
{
    public class ConvertValue
    {
        public static void ConvertV()
        {
            Console.WriteLine("Input: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Output:" + a + " centuries = " + a * 100 + " years = " + a * 365 + " days = " + a * 365 * 24 + " hours = " + a * 365 * 24 * 60 + "minutes = "
                            + a * 365 * 24 * 60 * 60 + " seconds = " + a * 365 * 24 * 60 * 60 * 1000 + " milliseconds = " + a * 365 * 24 * 60 * 60 * 1000000
                            + " microseconds = " + a * 365 * 24 * 60 * 60 * 1000000000 + " nanoseconds");
        }
    }
}
