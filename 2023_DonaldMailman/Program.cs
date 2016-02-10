using System;

namespace _2023_DonaldMailman
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = 0;
            int currentBox = 1;
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int nextBox = GetBox(Console.ReadLine());
                steps += Math.Abs(currentBox - nextBox);
                currentBox = nextBox;
            }

            Console.WriteLine(steps);
        }

        static int GetBox(string name)
        {
            switch (name[0])
            {
                case 'A':
                case 'O':
                case 'P':
                case 'R':
                    return 1;
                case 'B':
                case 'M':
                case 'S':
                    return 2;
                default: return 3;
            }
        }
    }
}
