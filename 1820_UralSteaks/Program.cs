using System;

namespace _1820_UralSteaks
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(input[0]);
            int k = Convert.ToInt32(input[1]);
            if (n < k)
            {
                Console.WriteLine(2);
            }
            else
            {
                if ((2 * n) % k == 0)
                {
                    Console.WriteLine(2 * n / k);
                }
                else
                {
                    Console.WriteLine(2 * n / k + 1);
                }
            }
        }
    }
}
