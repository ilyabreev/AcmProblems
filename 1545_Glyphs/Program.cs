using System;

namespace _1545_Glyphs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] glyphs = new string[n];
            for (int i = 0; i < n; i++)
            {
                glyphs[i] = Console.ReadLine();
            }

            char key = Console.ReadLine()[0];

            for (int i = 0; i < n; i++)
            {
                if (glyphs[i][0] == key)
                {
                    Console.WriteLine(glyphs[i]);
                }
            }
        }
    }
}
