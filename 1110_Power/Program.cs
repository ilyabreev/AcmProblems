using System;

namespace _1110_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            long n = long.Parse(input[0]);
            long m = long.Parse(input[1]);
            long y = long.Parse(input[2]);

            bool result = false;
            for (int i = 0; i < m; i++)
            {
                long x = i;
                if (n == 0)
                {
                    x = 1;
                }
                for (int j = 2; j <= n; j++)
                {
                    x = x * i % m;
                }
                if (x % m == y)
                {
                    Console.Write("{0} ", i);
                    result = true;
                }
            }

            if (!result)
            {
                Console.WriteLine(-1);
            }
        }
    }
}
