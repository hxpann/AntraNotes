using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class CalculatePrime
    {
        public static int[] FindPrimesInRange(int[] output, int startNum, int endNum)
        {
            int num, i, ctr;

            Console.Write("The prime numbers between {0} and {1} are : \n", startNum, endNum);

            for (num = startNum; num <= endNum; num++)
            {
                ctr = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && num != 1)
                    output.Append(num);
            }
            return output;
        }
    }

}