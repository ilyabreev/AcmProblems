using System;

namespace _1457_ExpectedValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long s = 0;
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                s += int.Parse(input[i]);
            }

            Console.WriteLine("{0:0.000000}", s / (double)n);
        }
    }
}
