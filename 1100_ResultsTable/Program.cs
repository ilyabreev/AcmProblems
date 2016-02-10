using System;
using System.Linq;

namespace _1100_ResultsTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Team[] teams = new Team[n];
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                teams[i].Id = Convert.ToInt32(input[0]);
                teams[i].M = Convert.ToInt32(input[1]);
            }

            foreach (var team in teams.OrderByDescending(t => t.M))
            {
                Console.WriteLine("{0} {1}", team.Id, team.M);
            }
        }

        struct Team
        {
            public int Id;
            public int M;
        }
    }
}
