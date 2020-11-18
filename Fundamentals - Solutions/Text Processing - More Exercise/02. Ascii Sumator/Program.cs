using System;

namespace _02._Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string str = Console.ReadLine();

            int start = (int)Math.Min(firstChar, secondChar);
            int end = (int)Math.Max(firstChar, secondChar);


            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                int currentChar = (int)(str[i]);
                if (currentChar > start && currentChar < end)
                {
                    sum += currentChar;
                }
            }

            Console.WriteLine(sum);
        }
    }
}