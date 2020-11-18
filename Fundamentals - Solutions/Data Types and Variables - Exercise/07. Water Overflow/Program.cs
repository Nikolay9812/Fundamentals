using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int capacity = int.Parse(Console.ReadLine());
                sum += capacity;
                if (sum > 255)
                {
                    sum -= capacity;
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
