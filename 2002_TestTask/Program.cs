using System;
using System.Collections.Generic;

namespace _2002_TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> registered = new Dictionary<string, string>();
            HashSet<string> loggedIn = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine().Split(' ');
                switch (cmd[0])
                {
                    case "register":
                        if (registered.ContainsKey(cmd[1]))
                        {
                            Console.WriteLine("fail: user already exists");
                        }
                        else
                        {
                            registered[cmd[1]] = cmd[2];
                            Console.WriteLine("success: new user added");
                        }
                        break;
                    case "login":
                        if (!registered.ContainsKey(cmd[1]))
                        {
                            Console.WriteLine("fail: no such user");
                        }
                        else if (cmd[2] != registered[cmd[1]])
                        {
                            Console.WriteLine("fail: incorrect password");
                        }
                        else if (loggedIn.Contains(cmd[1]))
                        {
                            Console.WriteLine("fail: already logged in");
                        }
                        else
                        {
                            loggedIn.Add(cmd[1]);
                            Console.WriteLine("success: user logged in");
                        }
                        break;
                    case "logout":
                        if (!registered.ContainsKey(cmd[1]))
                        {
                            Console.WriteLine("fail: no such user");
                        }
                        else if (!loggedIn.Contains(cmd[1]))
                        {
                            Console.WriteLine("fail: already logged out");
                        }
                        else
                        {
                            loggedIn.Remove(cmd[1]);
                            Console.WriteLine("success: user logged out");
                        }
                        break;
                }
            }
        }
    }
}
