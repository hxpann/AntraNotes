using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class RotateAndSumUp
    {
        public static int[] Myrotate(int[] nums, int k)
        {
            for (int i = 0; i < k; i++)
            {
                for (int j = nums.Length - 1; j > 0; j--)
                {
                    // move each number by 1 place
                    int temp = nums[j];
                    nums[j] = nums[j - 1];
                    nums[j - 1] = temp;
                }
                Console.WriteLine("Array rotation after " + (i + 1) + " step");
                Console.WriteLine(nums);
            }
            return nums;

            for (int i = 0; i < nums.Length - 1; i++)
            { 
                int output;
                output = nums[i] + nums[i + 1];
                Console.WriteLine("{i} ",output);
            }
            Console.WriteLine(nums[nums.Length-1]+nums[0]);

        }

    }
}
