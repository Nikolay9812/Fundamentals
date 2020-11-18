using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            Console.WriteLine(Caculation(firstNum,secondNum,thirdNum));
        }

        private static int Caculation(int firstNum, int secondNum, int thirdNum)
        {
            int sum = (firstNum + secondNum) - thirdNum;
            return sum;
        }
    }
}
