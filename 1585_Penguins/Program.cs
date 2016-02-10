using System;

namespace _1585_Penguins
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] p = new int[3];
            for (int i = 0; i < n; i++)
            {
                string penguin = Console.ReadLine();
                int j = penguin[0] == 'E' ? 0 : penguin[0] == 'M' ? 1 : 2;
                p[j]++;
            }

            int max = 0;
            int maxI = -1;
            for (int i = 0; i < 3; i++)
            {
                if (p[i] > max)
                {
                    max = p[i];
                    maxI = i;
                }
            }

            Console.WriteLine(maxI == 0 ? "Emperor Penguin" : maxI == 1 ? "Macaroni Penguin" : "Little Penguin");
        }
    }
}
