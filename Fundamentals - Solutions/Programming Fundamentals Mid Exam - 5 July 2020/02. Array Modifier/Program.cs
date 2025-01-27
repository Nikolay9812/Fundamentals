﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] element = command.Split();

                if (element[0] == "swap")
                {
                    int index1 = int.Parse(element[1]);
                    int index2 = int.Parse(element[2]);
                    int temp1 = numbers[index1];
                    int temp2 = numbers[index2];
                    numbers[index1] = temp2;
                    numbers[index2] = temp1;
                }
                else if (element[0] == "multiply")
                {
                    int index1 = int.Parse(element[1]);
                    int index2 = int.Parse(element[2]);
                    int multiplyNumber = numbers[index1] * numbers[index2];
                    numbers.RemoveAt(index1);
                    numbers.Insert(index1, multiplyNumber);
                }
                else if (element[0] == "decrease")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers[i]--;
                    }
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
