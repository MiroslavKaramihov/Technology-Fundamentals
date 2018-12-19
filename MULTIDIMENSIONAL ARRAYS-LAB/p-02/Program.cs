using System;
using System.Collections.Generic;
using System.Linq;

namespace p_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[size[0], size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            List<int> list = new List<int>(6);
            int count = 0;

            for (int i = 0; i < size[1]; i++)
            {
                list.Add(0);
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                count = row;
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int currNum = matrix[row, col];

                    list[col] += currNum;

                }
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
