using System;

namespace _03._Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());

            decimal precisionLevel = 0.000001M;


            if (Math.Abs(a - b) >= precisionLevel)
            {
                Console.WriteLine("False");

            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
