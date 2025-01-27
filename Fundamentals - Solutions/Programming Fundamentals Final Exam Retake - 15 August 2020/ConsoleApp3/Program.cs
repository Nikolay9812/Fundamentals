﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("|").ToArray();

                string piece = input[0];
                string composer = input[1];
                string key = input[2];

                data.Add(piece, new List<string>() { composer, key });
            }

            string command;

            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] element = command.Split("|");

                if (element[0] == "Add")
                {
                    string piece = element[1];
                    string composer = element[2];
                    string key = element[3];

                    if (!data.ContainsKey(piece))
                    {
                        data.Add(piece, new List<string>() { composer, key });
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }

                }
                else if (element[0] == "Remove")
                {
                    string piece = element[1];

                    if (data.ContainsKey(piece))
                    {
                        data.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if (element[0] == "ChangeKey")
                {
                    string piece = element[1];
                    string newKey = element[2];

                    if (data.ContainsKey(piece))
                    {
                        data[piece][1] = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
            }

            foreach (var item in data.OrderBy(x=>x.Key).ThenBy(k=>k.Value[0]))
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value[0]}, Key: {item.Value[1]}");
            }
        }
    }
}
