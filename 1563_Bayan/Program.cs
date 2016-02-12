using System;
using System.Collections.Generic;

namespace _1563_Bayan
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int bayans = 0;
            HashSet<string> shops = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string shop = Console.ReadLine().ToLower();
                if (shops.Contains(shop))
                {
                    bayans++;
                }
                else
                {
                    shops.Add(shop);
                }
            }

            Console.WriteLine(bayans);
        }
    }
}
