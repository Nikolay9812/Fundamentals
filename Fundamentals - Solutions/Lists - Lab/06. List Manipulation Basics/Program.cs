﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end") { break; }

                string[] tokens = line.Split();

                switch (tokens[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        numbers.Add(numberToAdd);
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        numbers.Remove(numberToRemove);
                        break;
                    case "RemoveAt":
                        int indexToRemoveAt = int.Parse(tokens[1]);
                        numbers.RemoveAt(indexToRemoveAt);
                        break;
                    case "Insert":
                        int numberToInset = int.Parse(tokens[1]);
                        int indexToInset = int.Parse(tokens[2]);
                        numbers.Insert(indexToInset, numberToInset);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
