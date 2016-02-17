using System;

namespace _1131_Copying
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            long n = long.Parse(input[0]);
            long k = long.Parse(input[1]);

            long t = 0;

            n -= 1;
            if (n == 0)
            {
                Console.WriteLine(0);
                return;
            }

            long l = 1 << 0;
            for (int i = 0; l <= k; i++)
            {
                if (n >= l)
                {
                    n -= l;
                    t += 1;
                    l = l << 1;
                }
                else if (n == 0)
                {
                    Console.WriteLine(t);
                    return;
                }
                else
                {
                    t += 1;
                    Console.WriteLine(t);
                    return;
                }
            }

            t += n / k;
            if (n % k > 0)
            {
                t += 1;
            }

            Console.WriteLine(t);
        }
    }
}
