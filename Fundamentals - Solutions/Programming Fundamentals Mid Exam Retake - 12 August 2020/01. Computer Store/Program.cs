﻿using System;

namespace _01._Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double totalPrice = 0;
            double taxes = 0;

            while (input != "special" || input != "regular")
            {
                if (input == "special" || input == "regular")
                {
                    break;
                }

                double price = double.Parse(input);

                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                    input = Console.ReadLine();
                    continue;
                }

                totalPrice += price;
                taxes += price * 0.20;


                input = Console.ReadLine();

                if (input == "special" || input == "regular")
                {
                    break;
                }
            }

            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPrice:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                if (input == "special")
                {
                    double total = totalPrice + taxes;
                    Console.WriteLine($"Total price: {total - total * 0.10:f2}$");
                }
                else if (input == "regular")
                {
                    Console.WriteLine($"Total price: {totalPrice + taxes:f2}$");
                }
            }

        }
    }
}
