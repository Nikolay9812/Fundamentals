using System;
using System.Linq;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            double sum = 0.0;


            for (int i = 0; i < input.Length; i++)
            {
                string currentString = input[i];


                double number = double.Parse((currentString.Substring(1, currentString.Length - 2)));
                char firstLetter = currentString[0];
                int firstLetterPosition = FindLetterPosinionInAlphabet(firstLetter);

                if (IsUpper(firstLetter))
                {
                    number /= firstLetterPosition;
                }
                else
                {
                    number *= firstLetterPosition;
                }

                char lastLetter = currentString[currentString.Length - 1];
                int lastLetterPosition = FindLetterPosinionInAlphabet(lastLetter);

                if (IsUpper(lastLetter))
                {
                    number -= lastLetterPosition;
                }

                else
                {
                    number += lastLetterPosition;
                }

                sum += number;

            }


            Console.WriteLine($"{sum:f2}");

        }

        private static bool IsUpper(char letter)
        {
            bool isUpper = letter >= 65 && letter <= 90;
            return isUpper;

        }

        private static int FindLetterPosinionInAlphabet(char letter)
        {
            bool isUpper = letter >= 65 && letter <= 90;
            int LetterPositioninAlphabet = 0;

            if (isUpper)
            {
                return LetterPositioninAlphabet = letter - 65 + 1;
            }

            else
            {
                return LetterPositioninAlphabet = letter - 97 + 1;
            }
        }
    }
}
