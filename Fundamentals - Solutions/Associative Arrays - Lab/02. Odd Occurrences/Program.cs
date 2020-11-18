using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().ToLower().Split().ToList();

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            foreach (string currWord in words)
            {
                if (dictionary.ContainsKey(currWord.ToLower()))
                {
                    dictionary[currWord]++;
                }
                else
                {
                    dictionary.Add(currWord, 1);
                }
            }

            foreach (var item in dictionary)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write(item.Key + " ");
                }
            }

        }
    }
}
