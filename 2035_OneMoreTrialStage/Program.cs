using System;

namespace _2035_OneMoreTrialStage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            long x = long.Parse(input[0]);
            long y = long.Parse(input[1]);
            long c = long.Parse(input[2]);

            if (x + y == c)
            {
                Console.WriteLine("{0} {1}", x, y);
                return;
            }

            long diff = c - (x + y);
            if (diff > 0)
            {
                Console.WriteLine("Impossible");
                return;
            }

            diff = Math.Abs(diff);

            long max = Math.Max(x, y);
            long min = Math.Min(x, y);

            bool maxX = max == x;

            if (max < diff)
            {
                min -= (diff - max);
                max = 0;
            }
            else
            {
                max -= diff;
            }

            Console.WriteLine("{0} {1}", maxX ? max : min, maxX ? min : max);
        }
    }
}
