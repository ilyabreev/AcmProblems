using System;

namespace _1327_Fuses
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int total = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 2 != 0)
                {
                    total++;
                }
            }

            Console.WriteLine(total);
        }
    }
}
