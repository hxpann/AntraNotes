using System;

namespace Assignment_2;

class FindMostFrequent {
     
    static int mostFrequent(int []arr, int n)
    {
         
        // Sort the array
        Array.Sort(arr);
         
        // find the max frequency using
        // linear traversal
        int max_count = 1, res = arr[0];
        int curr_count = 1;
         
        for (int i = 1; i < n; i++)
        {
            if (arr[i] == arr[i - 1])
                curr_count++;
            else
            {
                if (curr_count > max_count)
                {
                    max_count = curr_count;
                    res = arr[i - 1];
                }
                curr_count = 1;
            }
        }
     
        // If last element is most frequent
        if (curr_count > max_count)
        {
            max_count = curr_count;
            res = arr[n - 1];
        }
     
        return res;
    }
     
    // Driver code
    // public static void Main()
    // {
         
    //     int []arr = {1, 5, 2, 1, 3, 2, 1};
    //     int n = arr.Length;

    //     Console.WriteLine(mostFrequent(arr,n));
         
    // }
}