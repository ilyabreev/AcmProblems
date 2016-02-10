using System;

namespace _1639_Chocolate2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(input[0]);
            int n = Convert.ToInt32(input[1]);

            if ((n * m - 1) % 2 == 0)
            {
                Console.WriteLine("[second]=:]");
            }
            else
            {
                Console.WriteLine("[:=[first]");
            }
        }
    }
}
