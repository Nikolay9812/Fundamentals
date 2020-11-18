using System;

namespace _07._Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            int sum = 0;

            switch (typeOfDay)
            {
                case "Weekday":
                    if (0 <= age && age <= 18) {sum = 12;}
                    else if (18 <= age && age <= 64) { sum = 18; }
                    else if (64 <= age && age <= 122) { sum = 12; }
                    else
                    {
                        Console.WriteLine("Error!");
                        return;
                    }
                    break;
                case "Weekend":
                    if (0 <= age && age <= 18) { sum = 15; }
                    else if (18 <= age && age <= 64) { sum = 20; }
                    else if (64 <= age && age <= 122) { sum = 15; }
                    else
                    {
                        Console.WriteLine("Error!");
                        return;
                    }
                    break;
                case "Holiday":
                    if (0 <= age && age <= 18) { sum = 5; }
                    else if (18 <= age && age <= 64) { sum = 12; }
                    else if (64 <= age && age <= 122) { sum = 10; }
                    else
                    {
                        Console.WriteLine("Error!");
                        return;
                    }
                    break;
            }
            Console.WriteLine($"{sum}$");
        }
    }
}
