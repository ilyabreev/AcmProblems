using System;

namespace _1319_Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] box = new int[n, n];

            int i = 1;
            for (int j = n - 1; j >= 0; j--)
            {
                for (int k = 0, l = j; k < n - j; k++, l++)
                {
                    box[k, l] = i++;
                }

                if (j == 0)
                {
                    for (int k = 1; k < n; k++)
                    {
                        for (int l = 0, m = k; m < n; l++, m++)
                        {
                            box[m, l] = i++;
                        }
                    }
                }
            }

            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    Console.Write("{0} ", box[j, k]);
                }
                Console.Write("\n");
            }
        }
    }
}
