using System;

namespace _2066_SimpleExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (b == 0 || b == 1)
            {
                Console.WriteLine(a - b - c);
                return;
            }

            Console.WriteLine(a - b * c);
        }
    }
}
