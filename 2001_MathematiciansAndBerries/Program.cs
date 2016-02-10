using System;

namespace _2001_MathematiciansAndBerries
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] m = new int[3, 2];
            for (int i = 0; i < 3; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                m[i, 0] = Convert.ToInt32(input[0]);
                m[i, 1] = Convert.ToInt32(input[1]);
            }

            Console.WriteLine("{0} {1}", m[0, 0] - m[2, 0], m[0, 1] - m[1, 1]);
        }
    }
}