using System;
using System.Text.RegularExpressions;

namespace _06._Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(^|(?<=\s))[A-Za-z0-9]([\w\-\.]+)?[A-Za-z0-9]+@[a-zA-Z]+(\-)?[a-z]+\.[a-z]+(\.[a-z]+)?(?=\b|\s)";
            MatchCollection matchEMail = Regex.Matches(input, pattern);

            foreach (Match item in matchEMail)
            {
                Console.WriteLine(item);
            }
        }
    }
}
