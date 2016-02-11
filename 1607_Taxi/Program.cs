using System;

namespace _1607_Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            int d = int.Parse(input[3]);

            int at = a;
            int ct = c;
            int result = 0;
            while (at < ct)
            {
                if (at + b >= ct)
                {
                    result = ct;
                    break;
                }
                if (ct + d <= at)
                {
                    result = at;
                    break;
                }

                at += b;
                ct -= d;
            }

            Console.WriteLine(result != 0 ? result : Math.Max(at, ct));
        }
    }
}
