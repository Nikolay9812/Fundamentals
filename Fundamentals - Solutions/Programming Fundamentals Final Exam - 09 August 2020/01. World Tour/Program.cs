﻿using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append(input);

            string command;

            while ((command = Console.ReadLine()) != "Travel")
            {
                string[] element = command.Split(":",StringSplitOptions.RemoveEmptyEntries);

                if (element[0] == "Add Stop")
                {
                    int index = int.Parse(element[1]);
                    string word = element[2];

                    if (index >= 0 && index < sb.Length)
                    {
                        sb = sb.Insert(index, word);
                    }
                }
                else if (element[0] == "Remove Stop")
                {
                    int startIndex = int.Parse(element[1]);
                    int endIndex = int.Parse(element[2]);

                    if (startIndex >= 0 && endIndex >= 0 && endIndex < sb.Length)
                    {
                        sb = sb.Remove(startIndex, endIndex - startIndex + 1);
                    }

                }
                else if (element[0] == "Switch")
                {
                    string oldString = element[1];
                    string newString = element[2];

                    if (input.Contains(oldString))
                    {
                        sb = sb.Replace(oldString, newString);
                    }
                }

                Console.WriteLine(sb);
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {sb}");
        }
    }
}
