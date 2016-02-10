using System;

namespace _1876_CentipedesMorning
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(input[0]);
            int b = Convert.ToInt32(input[1]);

            Console.WriteLine(Math.Max(2 * a + 39, 2 * b + 40));
        }
    }
}
