using System;

namespace _02._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal input = decimal.Parse(Console.ReadLine());

            double converter = 1.31;

            Console.WriteLine($"{input*(decimal)converter:f3}");
        }
    }
}
