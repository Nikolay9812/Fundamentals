using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLeter = char.Parse(Console.ReadLine());
            char secondLeter = char.Parse(Console.ReadLine());

            ASCII(firstLeter, secondLeter);
        }

        static void ASCII(char firstLeter,char secondLeter)
        {
            int start = Math.Min(firstLeter, secondLeter);
            int end = Math.Max(firstLeter, secondLeter);

            for (int i = start + 1; i < end; i++)
            {
                char symbol = (char)i;
                Console.Write(symbol + " ");
            }
        }
    }
}
