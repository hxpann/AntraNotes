using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02UnderstandingTypes
{
    public class Greetings
    {
        public static void Greeting()
        {
            DateTime now = DateTime.Now;

            if (now.Hour >= 6 && now.Hour < 12)
            {
                Console.WriteLine("Good Morning!");
            }
            if (now.Hour >= 12 && now.Hour < 18)
            {
                Console.WriteLine("Good Afternoon!");
            }
            if (now.Hour >= 18)
            {
                Console.WriteLine("Good Evening!");
            }
            if (now.Hour >= 0 && now.Hour < 6)
            {
                Console.WriteLine("Good Night!");
            }
        }
    }
}
