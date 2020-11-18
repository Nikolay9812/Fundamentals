using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int fullCourses = 0;

            if (numberOfPeople / capacity != 0)
            {
                fullCourses = (int)Math.Ceiling((double)numberOfPeople / capacity);
            }
            else
            {
                fullCourses = (int)Math.Ceiling((double)numberOfPeople / capacity);
            }

            Console.WriteLine(fullCourses);
        }
    }
}
