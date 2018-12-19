using System;
using System.Linq;

namespace p_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int bestSum = 0;
            int[,] bestMatrix = new int[2, 2];

            for (int r = 0; r < matrix.GetLength(0); r++)
            {

                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (r + 1 >= matrix.GetLength(0) || c + 1 >= matrix.GetLength(1))
                    {
                        break;
                    }
                    var currSum = matrix[r, c] +
                        matrix[r, c + 1] +
                        matrix[r + 1, c] +
                        matrix[r + 1, c + 1];

                    if (bestSum < currSum)
                    {
                        bestSum = currSum;
                        bestMatrix[0, 0] = matrix[r, c];
                        bestMatrix[0, 1] = matrix[r, c + 1];
                        bestMatrix[1, 0] = matrix[r + 1, c];
                        bestMatrix[1, 1] = matrix[r + 1, c + 1];
                    }
                }
            }

            for (int r = 0; r < bestMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < bestMatrix.GetLength(1); c++)
                {
                    Console.Write($"{bestMatrix[r, c]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(bestSum);
        }
    }
}
