using System;

namespace Assignment_2
{
    public class ReverseWords
    {
        public static string MyReverseWords(string str)
        {       
            return String.Join(" ", str.Split('.', ',',':',';','=','(',')','&','[',']','\"','\'','\\','/','!','?',' ').Reverse()).ToString();
        }
    }
}