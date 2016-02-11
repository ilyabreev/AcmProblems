using System;
using System.Collections.Generic;

namespace _1196_HistoryExam
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> teacher = new HashSet<string>();
            int matches = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string year = Console.ReadLine();
                if (!teacher.Contains(year))
                {
                    teacher.Add(year);
                }
            }

            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                string year = Console.ReadLine();
                if (teacher.Contains(year))
                {
                    matches++;
                }
            }

            Console.WriteLine(matches);
        }
    }
}
