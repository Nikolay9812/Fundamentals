using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> topFive = new List<int>();


            double average = nums.Average();

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] > average)
                {
                    topFive.Add(nums[i]);
                }
            }

            topFive.Sort();
            topFive.Reverse();

            if (topFive.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }
            else
            {
                Console.WriteLine(string.Join(" ", topFive.Take(5)));
            }

        }

    }
}
