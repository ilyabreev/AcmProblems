using System;
using System.Collections.Generic;
using System.Linq;

namespace _1837_IsenbaevNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentNum = 0;
            bool[,] m = new bool[n * 3, n * 3];
            int[] len = new int[n * 3];
            bool[] marks = new bool[n * 3];
            for (int i = 0; i < n * 3; i++)
            {
                len[i] = -1;
            }

            Dictionary<string, int> players = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < 3; j++)
                {
                    if (!players.ContainsKey(input[j]))
                    {
                        players[input[j]] = currentNum++;
                    }
                }

                for (int j = 0; j <= 2; j++)
                {
                    for (int k = 0; k <= 2; k++)
                    {
                        m[players[input[j]], players[input[k]]] = true;
                    }
                }
            }

            if (!players.ContainsKey("Isenbaev"))
            {
                var a = players.Keys.OrderBy(k => k);
                foreach (var player in a)
                {
                    Console.WriteLine("{0} undefined", player);
                }
                return;
            }

            int isenbaev = players["Isenbaev"];
            len[isenbaev] = 0;
            Bfs(n * 3, m, len, marks, isenbaev);

            var alph = players.Keys.OrderBy(k => k);
            foreach (var player in alph)
            {
                int num = len[players[player]];
                Console.WriteLine("{0} {1}", player, num == -1 ? "undefined" : num.ToString());
            }
        }

        static void Bfs(int n, bool[,] m, int[] len, bool[] marks, int start)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(start);
            len[start] = 0;
            marks[start] = true;

            while (q.Any())
            {
                int v = q.Dequeue();
                for (int i = 0; i < n; i++)
                {
                    if (v != i && m[v, i] && !marks[i])
                    {
                        len[i] = len[v] + 1;
                        marks[i] = true;
                        q.Enqueue(i);
                    }
                }
            }
        }
    }
}
