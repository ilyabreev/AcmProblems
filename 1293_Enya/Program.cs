using System;

namespace _1293_Enya
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(input[0]);
            int a = Convert.ToInt32(input[1]);
            int b = Convert.ToInt32(input[2]);
            double result = a * b * n * 2;
            Console.WriteLine(result);
        }
    }
}
