using System;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] count = new int[n];

            for (int i = 0; i < n; i++)
            {
                count[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(" " , count));
            Console.WriteLine(count.Sum());
        }
    }
}
