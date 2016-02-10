using System;

namespace _1264_WorkDays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(input[0]);
            int m = Convert.ToInt32(input[1]);

            Console.WriteLine(n * (m + 1));
        }
    }
}
