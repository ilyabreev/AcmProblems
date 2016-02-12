using System;
using System.Collections.Generic;
using System.Linq;

namespace _1654_Cyphertext
{
    class Program
    {
        static void Main(string[] args)
        {
            string cypherText = Console.ReadLine();
            Stack<char> s = new Stack<char>();
            foreach (char c in cypherText)
            {
                if (s.Count > 0 && s.Peek() == c)
                {
                    s.Pop();
                }
                else
                {
                    s.Push(c);
                }
            }

            foreach (char c in s.Reverse())
            {
                Console.Write(c);
            }
        }
    }
}
