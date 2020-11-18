using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<int>> plantsAndData = new Dictionary<string, List<int>>();

            for (int i = 0; i < n; i++)
            {
                string[] plantData = Console.ReadLine().Split("<->");

                string plantName = plantData[0];
                int plantRarity = int.Parse(plantData[1]);

                if (plantsAndData.ContainsKey(plantName))
                {
                    plantsAndData[plantName][0] = plantRarity;
                }
                else
                {
                    plantsAndData.Add(plantName, new List<int>() { plantRarity });
                }
            }

            string[] input = Console.ReadLine().Split();

            while (input[0] != "Exhibition")
            {
                string plantName = input[1];

                switch (input[0])
                {
                    case "Rate:":

                        int newRating = int.Parse(input[3]);

                        if (plantsAndData.ContainsKey(plantName))
                        {
                            plantsAndData[plantName].Add(newRating);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }

                        break;

                    case "Update:":

                        int newRarity = int.Parse(input[3]);

                        if (plantsAndData.ContainsKey(plantName))
                        {
                            plantsAndData[plantName][0] = newRarity;
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }

                        break;

                    case "Reset:":

                        if (plantsAndData.ContainsKey(plantName))
                        {
                            plantsAndData[plantName].RemoveRange(1,
                            plantsAndData[plantName].Count - 1);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }

                        break;

                    default:

                        Console.WriteLine("error");

                        break;
                }

                input = Console.ReadLine().Split();
            }

            foreach (var plant in plantsAndData)
            {
                if (plant.Value.Count == 1)
                {
                    plant.Value.Add(0);
                }
            }

            plantsAndData = plantsAndData.OrderByDescending(plant => plant.Value[0])
                .ThenByDescending(plant => plant.Value.TakeLast(plant.Value.Count - 1)
                .Average()).ToDictionary(plant => plant.Key, plant => plant.Value);

            Console.WriteLine("Plants for the exhibition:");

            foreach (var plant in plantsAndData)
            {
                Console.Write($"- {plant.Key}; Rarity: {plant.Value[0]}; Rating: ");

                plant.Value.RemoveAt(0);

                Console.WriteLine($"{plant.Value.Average():F2}");
            }
        }
    }
}
