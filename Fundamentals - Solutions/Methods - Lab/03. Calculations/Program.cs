using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int First = int.Parse(Console.ReadLine());
            int Second = int.Parse(Console.ReadLine());

            if(input == "add") { Add(First,Second); }
            else if(input == "multiply") { Multiply(First, Second); }
            else if(input == "subtract") { Subtract(First, Second); }
            else if(input == "divide") { Divide(First, Second); }
        }

        static void Add(int First, int Second) { Console.WriteLine(First + Second); }
        static void Multiply(int First, int Second) {  Console.WriteLine(First * Second); }
        static void Subtract(int First, int Second) {  Console.WriteLine(First - Second); }
        static void Divide(int First, int Second) {  Console.WriteLine(First / Second); }
    }
}
