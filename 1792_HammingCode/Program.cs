using System;

namespace _1792_HammingCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] code = new int[4];
            int[] check = new int[3];
            bool[] ctrl = new bool[3];

            for (int i = 0; i < 7; i++)
            {
                if (i < 4)
                {
                    code[i] = int.Parse(input[i]);
                }
                else
                {
                    check[i - 4] = int.Parse(input[i]);
                }
            }

            ctrl[0] = (code[1] + code[3] + code[2]) % 2 == check[0];
            ctrl[1] = (code[0] + code[3] + code[2]) % 2 == check[1];
            ctrl[2] = (code[0] + code[1] + code[3]) % 2 == check[2];

            int e = -1;
            if (!ctrl[0] && !ctrl[1] && !ctrl[2])
            {
                e = 3;
            }
            else if (!ctrl[0] && !ctrl[1])
            {
                e = 2;
            }
            else if (!ctrl[1] && !ctrl[2])
            {
                e = 0;
            }
            else if (!ctrl[0] && !ctrl[2])
            {
                e = 1;
            }
            else if (!ctrl[0])
            {
                e = 4;
            }
            else if (!ctrl[1])
            {
                e = 5;
            }
            else if (!ctrl[2])
            {
                e = 6;
            }

            if (e != -1)
            {
                if (e < 4)
                {
                    code[e] = (code[e] + 1) % 2;
                }
                else
                {
                    check[e - 4] = (check[e - 4] + 1) % 2;
                }
            }

            for (int i = 0; i < 7; i++)
            {
                Console.Write("{0} ", i < 4 ? code[i] : check[i - 4]);
            }
        }
    }
}
