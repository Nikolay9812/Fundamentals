using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(\d{2})([-/.])([A-Z][a-z]{2})\2(\d{4})";
            MatchCollection matchDates = Regex.Matches(input, pattern);

            foreach (Match item in matchDates)
            {
                Console.WriteLine($"Day: {item.Groups[1]}, Month: {item.Groups[3]}, Year: {item.Groups[4]}");
            }
        }
    }
}
