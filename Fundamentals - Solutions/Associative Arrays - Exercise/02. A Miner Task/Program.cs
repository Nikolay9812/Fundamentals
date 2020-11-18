using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource = string.Empty;

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            while ((resource = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (dictionary.ContainsKey(resource))
                {
                    dictionary[resource] += quantity;
                }
                else
                {
                    dictionary[resource] = quantity;
                }

            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
