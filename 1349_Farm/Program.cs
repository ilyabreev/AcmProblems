using System;

namespace _1349_Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            // великая теорема Ферма
            int n = int.Parse(Console.ReadLine());
            if (n == 0 || n > 2)
            {
                Console.WriteLine(-1);
                return;
            }

            if (n == 1)
            {
                Console.WriteLine("1 2 3");
                return;
            }

            if (n == 2)
            {
                Console.WriteLine("3 4 5");
            }
        }
    }
}
