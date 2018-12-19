using System;
using System.Linq;

namespace p_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();
                char[] splitedInput = new char[size];

                for (int i = 0; i < input.Length; i++)
                {
                    splitedInput[i] = input[i];
                }

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            char surchSymbol = char.Parse(Console.ReadLine());
            int[] position = new int[2];
            bool isExisted = false;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == surchSymbol)
                    {
                        isExisted = true;
                        position[0] = row;
                        position[1] = col;
                    }
                }
            }

            if (isExisted)
            {
                Console.WriteLine($"({string.Join(", ", position)})");
            }
            else
            {
                Console.WriteLine($"{surchSymbol} does not occur in the matrix");
            }

        }
    }
}
