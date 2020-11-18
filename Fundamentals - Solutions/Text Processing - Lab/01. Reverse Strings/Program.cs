using System;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;

            while ((word = Console.ReadLine()) != "end")
            {
                string reversedWord = string.Empty;

                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reversedWord += word[i];
                }

                Console.WriteLine($"{word} = {reversedWord}");
            }
        }
    }
}
