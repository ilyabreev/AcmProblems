using System;

namespace _1149_SinusDances
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string a = "sin(1";
            string sn = "";
            for (int i = 0; i < n - 1; i++)
            {
                sn += "(";
            }

            int j = n;
            for (int i = 1; i <= n; i++)
            {
                string p = "";
                for (int k = 0; k < i; k++)
                {
                    p += ")";
                }
                sn += a + p + "+" + j.ToString() + ((i == n) ? "" : ")");
                j--;
                a += String.Format("{0}sin({1}", (i % 2 == 0) ? "+" : "-", (i + 1).ToString());
            }

            Console.WriteLine(sn);
        }
    }
}
