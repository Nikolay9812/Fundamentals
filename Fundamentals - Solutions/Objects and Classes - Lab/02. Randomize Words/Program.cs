using System;

namespace _02._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfWords = Console.ReadLine().Split();

            Random rnd = new Random();

            for (int i = 1; i < arrayOfWords.Length; i++)
            {
                int firstWord = rnd.Next(0, arrayOfWords.Length);
                int secondWord = rnd.Next(0, arrayOfWords.Length);

                string changer = arrayOfWords[firstWord];
                arrayOfWords[firstWord] = arrayOfWords[secondWord];
                arrayOfWords[secondWord] = changer;
            }

            Console.WriteLine(string.Join(Environment.NewLine, arrayOfWords));
        }
    }
}
