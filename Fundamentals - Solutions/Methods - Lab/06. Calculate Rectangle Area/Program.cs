using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double area = Calculations(x1, x2);
            Console.WriteLine(area);
        }

        static double Calculations ( double x1,double x2) { return x1* x2; }
    }
}
