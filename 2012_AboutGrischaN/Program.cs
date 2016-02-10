using System;

namespace _2012_AboutGrischaN
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = Convert.ToInt32(Console.ReadLine());
            string result = (12 - f <= 5) ? "YES" : "NO";
            Console.WriteLine(result);
        }
    }
}
