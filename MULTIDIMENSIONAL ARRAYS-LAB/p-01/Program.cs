using System;
using System.Linq;

namespace p_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersOfcolsAndRows = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[numbersOfcolsAndRows[0], numbersOfcolsAndRows[1]];

            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                int[] colElement = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    matrix[col, row] = colElement[row];
                }
            }

            int sum = 0;

            foreach (var item in matrix)
            {
                sum += item;
            }

            Console.WriteLine(numbersOfcolsAndRows[0]);
            Console.WriteLine(numbersOfcolsAndRows[1]);
            Console.WriteLine(sum);
        }
    }
}
