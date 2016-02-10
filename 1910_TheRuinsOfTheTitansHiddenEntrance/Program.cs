using System;

namespace _1910_TheRuinsOfTheTitansHiddenEntrance
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            int[] a = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                a[i] = Convert.ToInt32(input[i]);
            }

            int sum = 0;
            int index = 0;
            for (int i = 0; i < a.Length - 2; i++)
            {
                int tempSum = a[i] + a[i + 1] + a[i + 2];
                if (tempSum > sum)
                {
                    sum = tempSum;
                    index = i + 2;
                }
            }

            Console.WriteLine("{0} {1}", sum, index);
        }
    }
}
