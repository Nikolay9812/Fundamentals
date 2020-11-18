using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentsInformation = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (studentsInformation.ContainsKey(student))
                {
                    studentsInformation[student].Add(grade);
                }
                else
                {
                    studentsInformation.Add(student, new List<double>() { grade });
                }
            }

            Dictionary<string, double> average = new Dictionary<string, double>();


            foreach (var student in studentsInformation)
            {
                average.Add(student.Key, student.Value.Average());
            }

            foreach (var item in average.Where(student => student.Value >= 4.50).OrderByDescending(order => order.Value))
            {
                Console.WriteLine($"{item.Key} -> {item.Value:F2}");
            }
        }
    }
}
