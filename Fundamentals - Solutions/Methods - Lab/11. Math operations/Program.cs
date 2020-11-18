using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int secondNum = int.Parse(Console.ReadLine());
            Operator(firstNum, @operator, secondNum);
        }

        private static double Operator(int firstNum, string @operator, int secondNum)
        {
            double sum = 0;
            if (@operator == "/") { Console.WriteLine(sum = firstNum / secondNum); }
            else if (@operator == "*") { Console.WriteLine(sum = firstNum * secondNum); }
            else if (@operator == "+") { Console.WriteLine(sum = firstNum + secondNum); }
            else if (@operator == "-") { Console.WriteLine(sum = firstNum - secondNum); }
            return sum;
        }
    }
}
