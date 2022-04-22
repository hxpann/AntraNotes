using System;

namespace Assignment_2
{
    public class ReverseString
    {
        public static void MyReverseString()
        {
            Console.WriteLine("Enter the string you want to reverse: ");
            string input = Console.ReadLine();

            char[] charArr = input.ToCharArray();
            Array.Reverse(charArr);
            string output = charArr.ToString();
            Console.WriteLine(output);

        }
        public static void ReverseStringUsingForLoop(string stringInput)  
        {  
            // Reverse using for loop 
            //Convert input string to char array and loop through 
            char[] stringArray = stringInput.ToCharArray();  
            
            string reverse = String.Empty;  
  
            for (int i = stringArray.Length - 1; i >= 0; i--)  
            {  
                reverse += stringArray[i];  
            }  
        
            Console.WriteLine(reverse);  
        
            Console.ReadLine();  
        }  
    }
}