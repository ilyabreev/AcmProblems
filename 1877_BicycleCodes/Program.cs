using System;

namespace _1877_BicycleCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int code1 = Convert.ToInt32(Console.ReadLine());
            int code2 = Convert.ToInt32(Console.ReadLine());

            string result = (code1 % 2 == 0 || code2 % 2 != 0) ? "yes" : "no";
            Console.WriteLine(result);
        }
    }
}
