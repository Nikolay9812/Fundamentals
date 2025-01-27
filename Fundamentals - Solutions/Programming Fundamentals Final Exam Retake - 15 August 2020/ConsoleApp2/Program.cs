﻿using System;
using System.Text.RegularExpressions;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex pattern = new Regex(@"(\||\#)([A-Za-z ]+)\1([0-9]{2})\/([0-9]{2})\/([0-9]{2})\1([0-9]+)\1");

            MatchCollection matches = pattern.Matches(input);

            int calories = 0;

            foreach (Match item in matches)
            {
                calories += int.Parse(item.Groups[6].ToString());
            }

            int days = calories / 2000;

            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (Match item in matches)
            {
                Console.WriteLine($"Item: {item.Groups[2]}, Best before: {item.Groups[3]}/{item.Groups[4]}/{item.Groups[5]}, Nutrition: {item.Groups[6]}");
            }

        }
    }
}
