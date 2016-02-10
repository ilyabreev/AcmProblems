using System;

namespace _1581_TeamWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            int currentNumber = Convert.ToInt32(input[0]);
            int count = 1;
            for (int i = 1; i < n; i++)
            {
                int nextNumber = Convert.ToInt32(input[i]);
                if (nextNumber == currentNumber)
                {
                    count++;
                    continue;
                }

                Console.Write("{0} {1} ", count, currentNumber);
                currentNumber = nextNumber;
                count = 1;
            }

            Console.Write("{0} {1} ", count, currentNumber);
        }
    }
}
