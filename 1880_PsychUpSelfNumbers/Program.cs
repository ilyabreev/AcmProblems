using System;

namespace _1880_PsychUpSelfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] numbers = new int[3][];
            for (int i = 0; i < 3; i++)
            {
                int count = Convert.ToInt32(Console.ReadLine());
                string[] input = Console.ReadLine().Split(' ');
                numbers[i] = new int[count];
                for (int j = 0; j < count; j++)
                {
                    numbers[i][j] = Convert.ToInt32(input[j]);
                }
            }

            int result = 0;
            for (int i = 0; i < numbers[0].Length; i++)
            {
                if (BinarySearchIterative(numbers[1], numbers[0][i], 0, numbers[1].Length - 1) &&
                    BinarySearchIterative(numbers[2], numbers[0][i], 0, numbers[2].Length - 1))
                {
                    result++;
                }
            }

            Console.WriteLine(result);
        }

        public static bool BinarySearchIterative(int[] inputArray, int key, int min, int max)
        {
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return true;
                }
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            return false;
        }
    }
}
