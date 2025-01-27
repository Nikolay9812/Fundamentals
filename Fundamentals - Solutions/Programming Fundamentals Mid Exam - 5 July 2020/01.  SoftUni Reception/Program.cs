﻿using System;

namespace _01.__SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int allEmployees = 0;

            for (int i = 0; i < 3; i++)
            {
                int eachEmployeeEfficiency = int.Parse(Console.ReadLine());
                allEmployees += eachEmployeeEfficiency;
            }

            int studentsCount = int.Parse(Console.ReadLine());
            int hoursCounter = 0;

            while (studentsCount > 0)
            {
                hoursCounter++;
                if (hoursCounter % 4 == 0) { continue; }
                studentsCount -= allEmployees;
            }

            Console.WriteLine($"Time needed: {hoursCounter}h.");
        }
    }
}
