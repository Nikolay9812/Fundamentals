﻿using System;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string temp = arr[0];

                for (int j = 0; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }

                arr[arr.Length - 1] = temp;
            }

            Console.WriteLine(string.Join(" ",arr));
        }
    }
}
