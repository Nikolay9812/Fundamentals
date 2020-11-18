﻿using System;

namespace _01._Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BodyPart(n);
        }

        static void BodyPart (int n)
        {
            if (n > 0) { Console.WriteLine($"The number {n} is positive."); }
            else if (n < 0) { Console.WriteLine($"The number {n} is negative."); }
            else { Console.WriteLine($"The number {n} is zero."); }
        }

    }
}
