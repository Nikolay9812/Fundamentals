using System;
using System.Numerics;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //BigInteger number = BigInteger.Parse(Console.ReadLine());
            //int digit = int.Parse(Console.ReadLine());

            //BigInteger result = number * digit;

            //Console.WriteLine(result);

            string input = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine(0);
                return;
            }

            Console.WriteLine(Calculator(input, number));
        }

        public static StringBuilder Calculator(string input, int number)
        {
            while (input[0] == '0')
            {
                input = input.Substring(1);
            }

            StringBuilder sb = new StringBuilder();

            int remainder = 0;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                int currResult = int.Parse(input[i].ToString()) * number + remainder;
                remainder = 0;

                if (currResult > 9)
                {
                    remainder = currResult / 10;
                    currResult = currResult % 10;
                }

                sb.Append(currResult);
            }

            if (remainder != 0)
            {
                sb.Append(remainder);
            }

            StringBuilder result = new StringBuilder();

            for (int i = sb.Length - 1; i >= 0; i--)
            {
                result.Append(sb[i]);
            }

            return result;
        }
    }
}