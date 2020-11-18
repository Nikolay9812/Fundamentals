using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            if (input == "coffee") { Coffee(n); }
            else if (input == "water") { Water(n); }
            else if (input == "coke") { Coke(n); }
            else if (input == "snacks") { Snacks(n); }
        }

        static void Coffee(int n) { Console.WriteLine($"{(n * 1.50):f2}"); }
        static void Water(int n) { Console.WriteLine($"{(n * 1.00):f2}"); }
        static void Coke(int n) { Console.WriteLine($"{(n * 1.40):f2}"); }
        static void Snacks(int n) { Console.WriteLine($"{(n * 2.00):f2}"); }
    }
}