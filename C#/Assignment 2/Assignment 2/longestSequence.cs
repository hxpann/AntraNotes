using System;
using System.Collections.Generic;

class FindLongestSeq
{
    static int myLongestSeq(int[] arr, int n)
    {
        Array.Sort(arr);
        int ans = 0, count = 0;

        List<int> v = new List<int>();
        v.Add(10);

        for (int i = 1; i < n; i++)
        {
            if  (arr[i] != arr[i - 1])
                v.Add(arr[i]);
        }

        for (int i = 0; i < v.Count; i++)
        {
            if (i > 0 && v[i] == v[i - 1] + 1)
                count++;
            else
                count = 1;
            
            ans = Math.Max(ans,count);
        }
        return ans;

    }
    //static void Main()
    //{
    // int[] arr = { 1, 9, 3, 10, 4, 20, 2 };
    // int n = arr.Length;
 
    // Console.WriteLine("Length of the Longest " +
    //                   "contiguous subsequence is " +
    //                   myLongestSeq(arr, n));
    //}
}
