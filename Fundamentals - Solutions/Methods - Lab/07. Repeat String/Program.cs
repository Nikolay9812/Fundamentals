using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int multipler = int.Parse(Console.ReadLine());

            Console.Write(Body(multipler,input));
        }

        private static string Body (int multipler,string input)
        {
            string result = ""; 

            for (int i = 0; i < multipler; i++)
            {
                result += input;
            }

            return result;
        }
    }
}
