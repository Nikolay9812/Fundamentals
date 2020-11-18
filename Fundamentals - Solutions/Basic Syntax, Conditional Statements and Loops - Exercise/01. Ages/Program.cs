using System;

namespace _01._Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string text = "";

            if (0 <= input && input <= 2) { text = "baby"; }
            else if (3 <= input && input <= 13) { text = "child"; }
            else if (14 <= input && input <= 19) { text = "teenager"; }
            else if (20 <= input && input <= 65) { text = "adult"; }
            else if (66 <= input) { text = "elder"; }

            Console.WriteLine(text);
        }
    }
}
