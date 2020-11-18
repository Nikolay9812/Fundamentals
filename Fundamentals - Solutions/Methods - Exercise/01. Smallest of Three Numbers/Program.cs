using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            Solution(first, second, third);


        }

        static void Solution(int first, int second, int third)
        {
            int min = Math.Min(first, second);
            int minimum = Math.Min(min, third);

            Console.WriteLine(minimum);
        }
    }
}
