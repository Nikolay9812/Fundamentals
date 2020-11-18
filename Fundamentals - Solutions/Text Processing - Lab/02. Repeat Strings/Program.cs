using System;
using System.Text;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfStrings = Console.ReadLine().Split();

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                string word = arrayOfStrings[i];

                for (int w = 0; w < word.Length; w++)
                {
                    result.Append(word);
                }

            }

            Console.Write(result.ToString());
        }
    }
}
