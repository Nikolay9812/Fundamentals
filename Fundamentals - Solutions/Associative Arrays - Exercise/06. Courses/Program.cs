using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            Dictionary<string, List<string>> courseInformation = new Dictionary<string, List<string>>();


            while ((input = Console.ReadLine()) != "end")
            {
                string[] element = input.Split(" : ");

                string courseName = element[0];
                string studentName = element[1];

                if (courseInformation.ContainsKey(courseName))
                {
                    courseInformation[courseName].Add(studentName);
                }
                else
                {
                    courseInformation.Add(courseName, new List<string>() { studentName });
                }
            }

            foreach (var course in courseInformation.OrderByDescending(x=>x.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                foreach (var item in course.Value.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {item}");
                }

            }

        }
    }
}
