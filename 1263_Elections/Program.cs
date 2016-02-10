using System;

namespace _1263_Elections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(input[0]);
            int m = Convert.ToInt32(input[1]);

            int[] votes = new int[n];

            for (int i = 0; i < m; i++)
            {
                int v = Convert.ToInt32(Console.ReadLine());
                votes[v - 1]++;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0:0.00}%", votes[i] / (float)m * 100);
            }

            Console.ReadLine();
        }
    }
}
