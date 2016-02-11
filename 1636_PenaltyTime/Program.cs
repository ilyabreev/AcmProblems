using System;

namespace _1636_PenaltyTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int t1 = int.Parse(input[0]);
            int t2 = int.Parse(input[1]);

            input = Console.ReadLine().Split(' ');
            for (int i = 0; i < 10; i++)
            {
                t2 -= int.Parse(input[i]) * 20;
            }

            if (t2 > t1 || t2 == t1)
            {
                Console.WriteLine("No chance.");
            }
            else
            {
                Console.WriteLine("Dirty debug :(");
            }
        }
    }
}
