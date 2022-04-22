using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02UnderstandingTypes
{
    public class GuessNumber
    {
        public static void Guess()
        {
            int guessedNumber;
            int correctNumber;
            int guesses;

            guessedNumber = 0;
            correctNumber = new Random().Next(3) + 1;
            guesses = 0;

            while (guessedNumber != correctNumber)
            {
                Console.WriteLine("Please guess the number between 1 and 3: ");
                guessedNumber = int.Parse(Console.ReadLine());

                if (correctNumber > guessedNumber)
                {
                    Console.WriteLine("Your guess is low");
                }
                else if (correctNumber < guessedNumber)
                {
                    Console.WriteLine("Your guess is high");
                }
                else if (guessedNumber < 1 || guessedNumber > 3)
                {
                    Console.WriteLine("Your guessing number is out of range.");
                }
                guesses++;
            }
            Console.WriteLine("Your guess is correct!");
        }
    }
}
