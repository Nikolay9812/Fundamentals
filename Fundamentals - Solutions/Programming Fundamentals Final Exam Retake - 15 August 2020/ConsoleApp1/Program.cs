using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command;

            while ((command = Console.ReadLine()) != "Decode")
            {
                string[] element = command.Split("|", StringSplitOptions.RemoveEmptyEntries);

                if (element[0] == "Move")
                {
                    int NumberOfLetters = int.Parse(element[1]);
                    string word = input.Substring(0, NumberOfLetters);
                    if (input.Contains(word))
                    {
                        input = input.Remove(input.IndexOf(word), word.Length);
                        input = input + word;
                    }

                }
                else if (element[0] == "Insert")
                {
                    int index = int.Parse(element[1]);
                    string value = element[2];

                    input = input.Insert(index, value);
                }
                else if (element[0] == "ChangeAll")
                {
                    string substring = element[1];
                    string replacement = element[2];

                    input = input.Replace(substring, replacement);

                }
            }

            Console.WriteLine($"The decrypted message is: {input}");
        }
    }
}
