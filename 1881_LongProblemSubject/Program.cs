using System;

namespace _1881_LongProblemSubject
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int h = Convert.ToInt32(input[0]);
            int w = Convert.ToInt32(input[1]);
            int n = Convert.ToInt32(input[2]);

            int currentH = 1;
            int currentW = 0;
            int pages = 1;
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                if (currentW == 0)
                {
                    currentW += word.Length;
                }
                else
                {
                    if (currentW + 1 + word.Length <= w)
                    {
                        currentW += 1 + word.Length;
                    }
                    else
                    {
                        currentH++;
                        if (currentH > h)
                        {
                            currentH = 1;
                            pages++;
                        }

                        currentW = word.Length;
                    }
                }
            }

            Console.WriteLine(pages);
        }
    }
}
