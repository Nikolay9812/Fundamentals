using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double pow = double.Parse(Console.ReadLine());

            Console.WriteLine(Calculations(number,pow));
        }

        private static double Calculations(double number, double pow) 
        {
            double result = Math.Pow(number, pow);
            return result;
        }
    }
}