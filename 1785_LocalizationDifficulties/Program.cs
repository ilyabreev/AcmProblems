using System;

namespace _1785_LocalizationDifficulties
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            string result = "";
            if (num <= 4)
            {
                result = "few";
            }
            else if (num <= 9)
            {
                result = "several";
            }
            else if (num <= 19)
            {
                result = "pack";
            }
            else if (num <= 49)
            {
                result = "lots";
            }
            else if (num <= 99)
            {
                result = "horde";
            }
            else if (num <= 249)
            {
                result = "throng";
            }
            else if (num <= 499)
            {
                result = "swarm";
            }
            else if (num <= 999)
            {
                result = "zounds";
            }
            else
            {
                result = "legion";
            }

            Console.WriteLine(result);
        }
    }
}
