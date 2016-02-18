using System;

namespace _1712_CypherGrid
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] c = new bool[4, 4];
            char[,] m = new char[4, 4];
            for (int i = 0; i < 4; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < 4; j++)
                {
                    if (input[j] == 'X')
                    {
                        c[i, j] = true;
                    }
                }
            }

            for (int i = 0; i < 4; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < 4; j++)
                {
                    m[i, j] = input[j];
                }
            }

            for (int i = 0; i < 4; i++)
            {
                Console.Write(Get(c, m, 4));
                Turn(c, 4);
            }
        }

        static void Turn(bool[,] matr, int n)
        {
            bool tmp;
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = i; j < n - 1 - i; j++)
                {
                    tmp = matr[i, j];
                    matr[i, j] = matr[n - j - 1, i];
                    matr[n - j - 1, i] = matr[n - i - 1, n - j - 1];
                    matr[n - i - 1, n - j - 1] = matr[j, n - i - 1];
                    matr[j, n - i - 1] = tmp;
                }
            }
        }

        static string Get(bool[,] c, char[,] m, int n)
        {
            string r = "";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (c[i, j])
                    {
                        r += m[i, j];
                    }
                }
            }

            return r;
        }
    }
}
