using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1567_SMSSpam
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int total = 0;
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'a':
                    case 'd':
                    case 'g':
                    case 'j':
                    case 'm':
                    case 'p':
                    case 's':
                    case 'v':
                    case 'y':
                    case '.':
                    case ' ':
                        total += 1;
                        break;
                    case 'b':
                    case 'e':
                    case 'h':
                    case 'k':
                    case 'n':
                    case 'q':
                    case 't':
                    case 'w':
                    case 'z':
                    case ',':
                        total += 2;
                        break;
                    default:
                        total += 3;
                        break;
                }
            }

            Console.WriteLine(total);
        }
    }
}
