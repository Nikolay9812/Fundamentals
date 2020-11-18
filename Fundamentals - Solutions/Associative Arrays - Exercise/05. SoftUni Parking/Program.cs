using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> dataBase = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] command = input.Split();

                if (command[0] == "register")
                {
                    string username = command[1];
                    string licensePlateNumber = command[2];
                    if (!dataBase.ContainsKey(username))
                    {
                        dataBase.Add(username, licensePlateNumber);
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                }
                else if (command[0] == "unregister")
                {
                    string username = command[1];
                    if (dataBase.ContainsKey(username))
                    {
                        dataBase.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }
            }

            foreach (var data in dataBase)
            {
                string username = data.Key;
                string licensePlateNumber = data.Value;

                Console.WriteLine($"{username} => {licensePlateNumber}");
            }
        }
    }
}
