using System;
using System.Collections.Generic;

namespace _1496_Spamer
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> accounts = new HashSet<string>();
            HashSet<string> spamers = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string account = Console.ReadLine();
                if (accounts.Contains(account))
                {
                    if (!spamers.Contains(account))
                    {
                        spamers.Add(account);
                    }
                }
                else
                {
                    accounts.Add(account);
                }
            }

            foreach (var spamer in spamers)
            {
                Console.WriteLine(spamer);
            }
        }
    }
}
