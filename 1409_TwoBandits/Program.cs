using System;

namespace _1409_TwoBandits
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int harry = Convert.ToInt32(input[0]);
            int larry = Convert.ToInt32(input[1]);
            int totalJars = harry - 1 + larry;
            Console.WriteLine("{0} {1}", totalJars - harry, totalJars - larry);
        }
    }
}
