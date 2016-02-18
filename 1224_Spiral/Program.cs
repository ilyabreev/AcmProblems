using System;

namespace _1224_Spiral
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            long n = long.Parse(input[0]);
            long m = long.Parse(input[1]);

            Console.WriteLine((Math.Min(n - 1, m - 1) << 1) + (n > m ? 1 : 0));
        }
    }
}
