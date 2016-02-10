using System;

namespace _1991_BattleInTheSwamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(input[0]);
            int k = Convert.ToInt32(input[1]);
            input = Console.ReadLine().Split(' ');

            long alive = 0;
            long booms = 0;
            for (int i = 0; i < n; i++)
            {
                int t = k - Convert.ToInt32(input[i]);
                if (t > 0)
                {
                    alive += t;
                }
                else if (t < 0)
                {
                    booms += t;
                }
            }

            Console.WriteLine("{0} {1}", Math.Abs(booms), alive);
        }
    }
}
