﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex pattern = new Regex(@"(=|\/)([A-Z][a-z]{2,})\1");

            MatchCollection match = pattern.Matches(input);

            List<string> name = new List<string>();

            int sum = 0;

            foreach (Match item in match)
            {
                name.Add(item.Groups[2].Value);
                sum += item.Groups[2].Length;
            }

            Console.WriteLine($"Destinations: {string.Join(", ", name)}");
            Console.WriteLine($"Travel Points: {sum}");
        }
    }
}
