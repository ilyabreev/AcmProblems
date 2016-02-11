using System;

namespace _1493_OneStepToHappiness
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int t = int.Parse(input);
            int p = t-1;
            if (Check(p))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                int n = t+1;
                if (Check(n))
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }

        static bool Check(int t)
        {
            int l = 0;
            int r = 0;
            string s = t.ToString("D6");
            int[] digits = new int[6];
            for (int i = 0; i < 6; i++)
            {
                digits[i] = int.Parse(s[i].ToString());
            }

            for (int i = 0; i < 3; i++)
            {
                l += digits[i];
            }
            for (int i = 3; i < 6; i++)
            {
                r += digits[i];
            }

            return l == r;
        }
    }
}
