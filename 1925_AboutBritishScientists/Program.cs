using System;

namespace _1925_AboutBritishScientists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);
            int idealSum = 0;
            int realSum = 0;
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(' ');
                idealSum += int.Parse(input[0]) - 2;
                realSum += int.Parse(input[1]);
            }

            idealSum += k - 2;

            int num = idealSum - realSum;
            if (num < 0)
            {
                Console.WriteLine("Big Bang!");
            }
            else
            {
                Console.WriteLine(idealSum - realSum);
            }
        }
    }
}
