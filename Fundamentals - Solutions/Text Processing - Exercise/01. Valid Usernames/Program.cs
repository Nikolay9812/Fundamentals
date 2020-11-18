using System;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] users = Console.ReadLine().Split(", ");

            foreach (string user in users)
            {
                if (ValidateUsername(user))
                {
                    Console.WriteLine(user);
                }
            }
        }
        private static bool ValidateUsername(string username)
        {
            if (username.Length < 3 || username.Length > 16)
            {
                return false;
            }

            for (int i = 0; i < username.Length; i++)
            {
                char symbol = username[i];

                if (!char.IsLetterOrDigit(symbol) && symbol != '-' && symbol != '_')
                {
                    return false;
                }
            }

            return true;
        }
    }
}
