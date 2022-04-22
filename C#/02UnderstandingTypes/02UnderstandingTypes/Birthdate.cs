using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02UnderstandingTypes
{
    public class Birthdate
    {
        public static void DaysOld()
        {
            DateTime birthdate;
            DateTime today;
            int daysold;

            Console.WriteLine("Please enter the birthdate: ");
            birthdate = DateTime.Parse(Console.ReadLine());
            today = DateTime.Now;
            daysold = (today - birthdate).Days;

            Console.WriteLine(daysold);
            
        }
    }
}
