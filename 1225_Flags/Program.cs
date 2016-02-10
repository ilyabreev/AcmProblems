using System;

namespace _1225_Flags
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 1 || n == 2)
            {
                Console.WriteLine(2);
                return;
            }

            long[] flags = new long[n];
            flags[0] = 2;
            flags[1] = 2;

            for (int i = 2; i < n; i++)
            {
                flags[i] = flags[i - 1] + flags[i - 2];
            }

            Console.WriteLine(flags[n - 1]);
        }
    }
}
