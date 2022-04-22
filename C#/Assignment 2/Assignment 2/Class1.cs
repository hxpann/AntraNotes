using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class CopyArray
    {
        public static void MyCopyArray()
        {
            int[] array1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int[] array2 = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                array2[i] = array1[i];
            }
            foreach (int i in array1)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine("");
            foreach (int j in array2)
            {
                Console.Write("{0} ", j);
            }

        }
    }
}
