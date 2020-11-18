using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();

            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                for (int j = 0; j < word.Length; j++)
                {
                    if (!dictionary.ContainsKey(word[j]))
                    {
                        dictionary.Add(word[j], 1);
                    }
                    else
                    {
                        dictionary[word[j]]++;
                    }

                }
            }

            foreach (var word in dictionary)
            {
                Console.WriteLine($"{word.Key} -> {word.Value}");
            }
        }
    }
}
