using System;
using System.Text;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            string text = Console.ReadLine();

            int index = 0;

            while ((index = text.IndexOf(word)) != -1)
            {
                text = text.Remove(index, word.Length);
            }

            Console.WriteLine(text);
        }
    }
}
