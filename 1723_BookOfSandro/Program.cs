using System;
using System.Linq;

namespace _1723_BookOfSandro
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(input.GroupBy(c => c).OrderByDescending(g => g.Count()).First().Key);
        }
    }
}
