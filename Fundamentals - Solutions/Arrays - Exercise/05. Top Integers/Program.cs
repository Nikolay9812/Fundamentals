using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string result = "";

            for (int i = 0; i < arr.Length; i++)
            {
                int current = arr[i];
                bool isTop = true;

                for (int j = i+1; j < arr.Length; j++)
                {
                    if (current <= arr[j])
                    {
                        isTop = false;
                        break;
                    }
                }

                if (isTop)
                {
                    result += current + " ";
                }
            }

            Console.WriteLine(result);
        }
    }
}
