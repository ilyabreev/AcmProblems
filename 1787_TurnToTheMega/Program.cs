using System;

namespace _1787_TurnToTheMega
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split(' ');
            string[] input2 = Console.ReadLine().Split(' ');
            int k = Convert.ToInt32(input1[0]);
            int n = Convert.ToInt32(input1[1]);
            int jam = 0;
            for (int i = 0; i < n; i++)
            {
                int ai = Convert.ToInt32(input2[i]);
                jam += ai;
                if (jam >= k)
                {
                    jam -= k;
                }
                else
                {
                    jam = 0;
                }
            }

            Console.WriteLine(jam);
        }
    }
}
