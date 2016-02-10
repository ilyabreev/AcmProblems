using System;

namespace _1243_DivorceOfSevenGnomes
{
    class Program
    {
        static void Main(string[] args)
        {
            int mod = 0;
            int index = 1;
            string input = Console.ReadLine();
            int[] num = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                num[i] = int.Parse(input[i].ToString());
            }

            int test = num[0];
            if (test / 7 > 0)
            {
                mod = test % 7;
            }
            else
            {
                test = num[0] * 10 + num[1];
                mod = test % 7;
                index++;
            }

            for (int i = index; i < num.Length; i++)
            {
                test = mod * 10 + num[i];
                mod = test % 7;
            }

            Console.WriteLine(mod);
        }
    }
}
