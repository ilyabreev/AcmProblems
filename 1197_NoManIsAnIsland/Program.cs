using System;

namespace _1197_NoManIsAnIsland
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string position = Console.ReadLine();
                int x = ('a' - position[0]) * -1;
                int y = Convert.ToInt32(position[1].ToString()) - 1;

                int[,] points = new int[8, 2];
                points[0, 0] = y - 2;
                points[0, 1] = x - 1;

                points[1, 0] = y - 1;
                points[1, 1] = x - 2;

                points[2, 0] = y + 1;
                points[2, 1] = x - 2;

                points[3, 0] = y + 2;
                points[3, 1] = x - 1;

                points[4, 0] = y + 2;
                points[4, 1] = x + 1;

                points[5, 0] = y + 1;
                points[5, 1] = x + 2;

                points[6, 0] = y - 1;
                points[6, 1] = x + 2;

                points[7, 0] = y - 2;
                points[7, 1] = x + 1;

                int result = 0;
                for (int j = 0; j < 8; j++)
                {
                    if (points[j, 0] >= 0 && points[j, 0] <= 7 && points[j, 1] >= 0 && points[j, 1] <= 7)
                    {
                        result++;
                    }
                }

                Console.WriteLine(result);
            }
        }
    }
}
