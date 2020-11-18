using System;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();

            string result = "";
            foreach (var item1 in arr2)
            {
                foreach (var item2 in arr1)
                {
                    if (item1 == item2)
                    {
                        result += item1 + " ";
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
