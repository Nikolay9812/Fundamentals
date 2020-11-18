using System;
using System.Collections.Generic;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            Dictionary<string, double> dictionaryPrice = new Dictionary<string, double>();
            Dictionary<string, int> dictionaryQuantity = new Dictionary<string, int>();

            while ((input = Console.ReadLine()) != "buy")
            {
                string[] elements = input.Split();
                string name = elements[0];
                double price = double.Parse(elements[1]);
                int quantity = int.Parse(elements[2]);

                if (!dictionaryPrice.ContainsKey(name))
                {
                    dictionaryPrice.Add(name,0);
                    dictionaryQuantity.Add(name,0);
                }

                dictionaryPrice[name] = price;
                dictionaryQuantity[name] += quantity;

            }

            foreach (var item in dictionaryPrice)
            {
                string name = item.Key;
                double price = item.Value;
                int quantity = dictionaryQuantity[name];
                double totalPrice = price * quantity;

                Console.WriteLine($"{name} -> {totalPrice:f2}");
            }
        }
    }
}
