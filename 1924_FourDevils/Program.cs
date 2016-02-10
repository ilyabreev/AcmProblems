using System;

namespace _1924_FourDevils
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum % 2 == 0 ? "black" : "grimy");
        }
    }
}
