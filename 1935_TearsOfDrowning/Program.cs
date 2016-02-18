using System;

namespace _1935_TearsOfDrowning
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = 0;
            int b = 0;
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(input[i]);
                if (a > b)
                {
                    b = a;
                }

                p += a;
            }

            p += b;

            Console.WriteLine(p);
        }
    }
}
