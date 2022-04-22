using System;
using System.Collections.Generic;
namespace Assignment_2
{
    public class FindPalindrome
    {
        static bool isPalindrome(string str)
        {
            int i = 0, j = str.Length - 1;
            
            // traversing from both the ends
            while (i < j)
            {
                
                // not palindrome
                if (str[i++] != str[j--])
                return false;
            }
            
            // palindrome
            return true;
        }
        static String findPalinWords(string str)
        {
        
            // 'final_str' to store the final
            // string and 'word' to one by one
            // store each word of 'str'
            string final_str = "", word = "";
            
            // add space at the end of 'str'
            str = str + " ";
            int n = str.Length;
            
            // traversing 'str'
            for (int i = 0; i < n; i++)
            {
            
                // accumulating characters of
                // the current word
                if (str[i] != ' ')
                    word = word + str[i];
                else
                {
                    // if 'word' is not palindrome
                // then a add it to 'final_str'
                if (isPalindrome(word))
                    final_str += word + " ";
         
                // reset
                word = "";
                }
            }
         
            // required final string
            return final_str;
        }
     
        // Driver code
//         public static void Main ()
//         {
//             string str = "Text contains malayalam "
//                             + "and level words";
//             Console.WriteLine(findPalinWords(str));
//         }
    }
        
}
