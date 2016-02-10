using System;

namespace _1893_A380
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int row = 0;
            char seat = 'X';
            if (input.Length == 2)
            {
                row = Convert.ToInt32(input[0].ToString());
                seat = input[1];
            }
            else
            {
                row = Convert.ToInt32(input.Substring(0, 2));
                seat = input[2];
            }

            if (row == 1 || row == 2)
            {
                if (seat == 'A' || seat == 'D')
                {
                    Console.WriteLine("window");
                    return;
                }
                else
                {
                    Console.WriteLine("aisle");
                    return;
                }
            }
            else if (row >= 3 && row <= 20)
            {
                if (seat == 'A' || seat == 'F')
                {
                    Console.WriteLine("window");
                    return;
                }
                else
                {
                    Console.WriteLine("aisle");
                    return;
                }
            }
            else
            {
                if (seat == 'A' || seat == 'K')
                {
                    Console.WriteLine("window");
                    return;
                }
                else if (seat == 'C' || seat == 'D' || seat == 'G' || seat == 'H')
                {
                    Console.WriteLine("aisle");
                    return;
                }
                else
                {
                    Console.WriteLine("neither");
                    return;
                }
            }
        }
    }
}
