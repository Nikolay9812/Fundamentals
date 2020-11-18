using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            double calculatingPercentages = 1.0 * N / 2;
            int pokes = 0;

            while (N >= M)
            {
                N -= M;
                if (calculatingPercentages == N)
                {
                    if (Y != 0)
                    {
                        N /= Y;
                    }
                }
                pokes++;
            }
            Console.WriteLine(N);
            Console.WriteLine(pokes);

        }
    }
}
