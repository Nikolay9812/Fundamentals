using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(@"\");

            string element = input[input.Length - 1];
            string[] name = element.Split(".");

            Console.WriteLine($"File name: {name[0]}");
            Console.WriteLine($"File extension: {name[1]}");
        }
    }
}
