using System;

namespace _2005_TaxiForProgrammers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] m = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < 5; j++)
                {
                    m[i, j] = int.Parse(input[j]);
                }
            }

            int[,] r = 
            {
                { 1, 2, 3, 4, 5 },
                { 1, 4, 3, 2, 5 },
                { 1, 3, 2, 4, 5 },
                { 1, 3, 4, 2, 5 }
            };

            int minIndex = -1;
            int minRoute = int.MaxValue;
            for (int i = 0; i < 4; i++)
            {
                int route = 0;
                for (int j = 1; j < 5; j++)
                {
                    route += m[r[i, j - 1] - 1, r[i, j] - 1];
                }

                if (route < minRoute)
                {
                    minRoute = route;
                    minIndex = i;
                }
            }

            Console.WriteLine(minRoute);
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0} ", r[minIndex, i]);
            }
        }
    }
}
