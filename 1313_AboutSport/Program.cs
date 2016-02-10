using System;

namespace _1313_AboutSport
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] m = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    m[i, j] = Convert.ToInt32(input[j]);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = i, k = 0; j >= 0 && k <= i; j--, k++)
                {
                    Console.Write("{0} ", m[j, k]);
                }

                if (i == n - 1)
                {
                    for (int l = 1; l < n; l++)
                    {
                        for (int j = i, k = l; j >= 0 && k <= i; j--, k++)
                        {
                            Console.Write("{0} ", m[j, k]);
                        }
                    }
                    
                }
            }
        }
    }
}
