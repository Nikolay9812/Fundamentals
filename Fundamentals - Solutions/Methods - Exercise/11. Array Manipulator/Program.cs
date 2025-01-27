﻿using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();

            if (command == "end")
            {
                Console.WriteLine($"[{string.Join(", ", numbers)}]");
            }

            while (command != "end")
            {
                string[] allCommands = command
                .Split();

                string mainCommand = allCommands[0];

                //string[] commandInput = mainCommand.Split();

                //string command = commandInput[0];

                if (mainCommand == "exchange")
                {
                    int index = int.Parse(allCommands[1]);

                    if (index >= 0 && index <= numbers.Length - 1)
                    {
                        ExchangeArray(numbers, index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (mainCommand == "max")
                {
                    string evenOrOdd = allCommands[1];

                    Console.WriteLine(FindMaxEvenOrOdd(evenOrOdd, numbers));
                }
                else if (mainCommand == "min")
                {
                    string evenOrOdd = allCommands[1];
                    Console.WriteLine(FindMinEvenOrOdd(evenOrOdd, numbers));
                }
                else if (mainCommand == "first")
                {
                    int countOfNumbers = int.Parse(allCommands[1]);
                    string evenOrOdd = allCommands[2];
                    PrintFirstEvenOrOdd(numbers, countOfNumbers, evenOrOdd);
                }
                else if (mainCommand == "last")
                {
                    int countOfNumbers = int.Parse(allCommands[1]);
                    string evenOrOdd = allCommands[2];
                    PrintLastEvenOrodd(numbers, countOfNumbers, evenOrOdd);
                }

                command = Console.ReadLine();

                if (command == "end")
                {
                    Console.WriteLine($"[{string.Join(", ", numbers)}]");
                }
            }
        }

        static void ExchangeArray(int[] numbers, int index)
        {
            int[] temp = new int[index + 1];

            // Тук намираме колко символа от лявата част на масива трябва да се преместят и ги запазваме в един стринг
            for (int i = 0; i <= index; i++)// index =2
            {
                temp[i] = numbers[i]; // ['1', '2', '3']
            }

            //Тук преместваме всички числа в масива с index + 1 позиции
            for (int i = 0; i <= index; i++)
            {
                for (int k = 0; k < numbers.Length - 1; k++)
                {
                    numbers[k] = numbers[k + 1];
                }
            }

            // Тук слагаме изрязаните числа от началото на масива, които ги запазихме в стринга, да са в края му
            int counter3 = 0;

            for (int i = numbers.Length - 1 - index; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(temp[counter3].ToString());
                counter3++;
            }

            //Console.WriteLine(string.Join(',', numbers));
        }

        static string FindMaxEvenOrOdd(string evenOrOdd, int[] numbers)
        {
            if (evenOrOdd == "even")
            {
                int max = int.MinValue;
                int indexPosition = -222;//////////////////////
                bool check = false;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        if (numbers[i] >= max)
                        {
                            max = numbers[i];
                            indexPosition = i;
                            check = true;
                        }
                    }
                }
                if (check)
                {
                    return indexPosition.ToString();
                }
                return "No matches";
            }
            else
            {
                int max = int.MinValue;
                int indexPosition = -222;//////////////////////
                bool check = false;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        if (numbers[i] >= max)
                        {
                            max = numbers[i];
                            indexPosition = i;
                            check = true;
                        }
                    }
                }
                if (check)
                {
                    return indexPosition.ToString();
                }

                return "No matches";
            }
        }

        static string FindMinEvenOrOdd(string evenOrOdd, int[] numbers)
        {
            if (evenOrOdd == "even")
            {
                int min = int.MaxValue;
                int indexPosition = -222;//////////////////////
                bool check = false;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        if (numbers[i] <= min)
                        {
                            min = numbers[i];
                            indexPosition = i;
                            check = true;
                        }
                    }
                }
                if (check)
                {
                    return indexPosition.ToString();
                }
                return "No matches";
            }
            else
            {
                int min = int.MaxValue;
                int indexPosition = -222;//////////////////////
                bool check = false;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        if (numbers[i] <= min)
                        {
                            min = numbers[i];
                            indexPosition = i;
                            check = true;
                        }
                    }
                }
                if (check)
                {
                    return indexPosition.ToString();
                }
                return "No matches";
            }
        }

        static void PrintFirstEvenOrOdd(int[] numbers, int count, string evenOrOdd)
        {
            int[] temp = new int[count];
            int counter = 0;
            int counterOfEvenDigits = 0;
            int zeroDigitCounter = 0;

            if (count > numbers.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                if (evenOrOdd == "odd")
                {

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] % 2 != 0)
                        {
                            temp[counter] = numbers[i];
                            counter++;
                            if (counter >= count)
                            {
                                break;
                            }
                        }
                    }
                    //Console.WriteLine($"[{string.Join(", ", temp)}]");
                    PrintArrayWithoutZero(temp);

                }
                else
                {
                    //Тук преброяваме колко even числа има в масива numbers
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            if (numbers[i] == 0)
                            {
                                zeroDigitCounter++;
                            }

                            temp[counterOfEvenDigits] = numbers[i];
                            counterOfEvenDigits++;

                            if (counterOfEvenDigits >= count)
                            {
                                break;
                            }
                        }
                    }

                    if (counterOfEvenDigits == 0)
                    {
                        Console.WriteLine("[]");
                    }
                    else
                    {
                        int fakeZeroCounter = 0 - zeroDigitCounter;

                        for (int i = 0; i < temp.Length; i++)
                        {
                            if (temp[i] == 0)
                            {
                                fakeZeroCounter++;
                            }
                        }

                        int[] finalArr = new int[temp.Length - fakeZeroCounter];

                        for (int i = 0; i < finalArr.Length; i++)
                        {
                            finalArr[i] = temp[i];
                        }

                        //temp = finalArr;
                        Console.WriteLine($"[{string.Join(", ", finalArr)}]");

                    }

                    //Console.WriteLine($"[{string.Join(", ", temp)}]");
                }
            }
        }

        static void PrintArrayWithoutZero(int[] temp)
        {
            int counter1 = 0;

            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] != 0)
                {
                    counter1++;
                }
            }

            int[] newTemp = new int[counter1];
            int counter2 = 0;

            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] != 0)
                {
                    newTemp[counter2] = temp[i];
                    counter2++;
                }
            }

            Console.WriteLine($"[{string.Join(", ", newTemp)}]");
        }

        static void PrintLastEvenOrodd(int[] numbers, int count, string evenOrOdd)
        {
            if (count > numbers.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                if (evenOrOdd == "odd")
                {
                    int counter8 = 0;
                    //тук намираме колко броя нечетни числа има в масива
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        if (numbers[j] % 2 != 0)
                        {
                            counter8++;
                        }
                    }

                    //Създаваме масив с толкова на брой елемента
                    int[] OddArr = new int[counter8];

                    counter8 = 0;

                    //Пълним новия масив само с нечетни стойности
                    for (int k = 0; k < numbers.Length; k++)
                    {
                        if (numbers[k] % 2 != 0)
                        {
                            OddArr[counter8] = numbers[k];
                            counter8++;
                        }
                    }

                    if (count >= OddArr.Length)
                    {
                        Console.WriteLine($"[{string.Join(", ", OddArr)}]");
                    }
                    else
                    {
                        //Правим нов масив който да ни държи само последните "count" на брой елемента
                        int[] temp = new int[count];

                        for (int i = 0; i < count; i++)
                        {
                            temp[i] = OddArr[OddArr.Length - count + i];
                        }

                        //Console.WriteLine($"[{string.Join(", ", temp)}]");
                        PrintArrayWithoutZero(temp);
                    }

                }
                else
                {
                    int counter8 = 0;

                    for (int j = 0; j < numbers.Length; j++)
                    {
                        if (numbers[j] % 2 == 0)
                        {
                            counter8++;
                        }
                    }

                    int[] evenArr = new int[counter8];

                    counter8 = 0;

                    for (int k = 0; k < numbers.Length; k++)
                    {
                        if (numbers[k] % 2 == 0)
                        {
                            evenArr[counter8] = numbers[k];
                            counter8++;
                        }
                    }

                    if (count >= evenArr.Length)
                    {
                        Console.WriteLine($"[{string.Join(", ", evenArr)}]");
                    }
                    else
                    {
                        int[] temp = new int[count];

                        for (int i = 0; i < temp.Length; i++)
                        {
                            temp[i] = evenArr[evenArr.Length - count + i];
                        }

                        //Console.WriteLine($"[{string.Join(", ", temp)}]");
                        PrintArrayWithoutZero(temp);
                    }
                }
            }
        }
    }
}
