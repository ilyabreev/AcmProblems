using System;

namespace _1617_Slides
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] wheels = new int[701];
            for (int i = 0; i < n; i++)
            {
                int d = int.Parse(Console.ReadLine());
                wheels[d]++;
            }

            int trains = 0;
            for (int i = 0; i < 701; i++)
            {
                if (wheels[i] == 0)
                {
                    continue;
                }

                trains += wheels[i] / 4;
            }


            Console.WriteLine(trains);
        }
    }
}
