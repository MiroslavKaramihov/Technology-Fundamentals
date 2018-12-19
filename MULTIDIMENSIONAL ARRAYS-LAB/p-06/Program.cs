using System;
using System.Linq;

namespace p_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizes = int.Parse(Console.ReadLine());
            int[,] matrix = new int[sizes, sizes];

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = input[c];
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string[] splitedInput = input.Split();
                string comand = splitedInput[0];
                int row = int.Parse(splitedInput[1]);
                int col = int.Parse(splitedInput[2]);
                int value = int.Parse(splitedInput[3]);

                if (row >= sizes || col >= sizes || row < 0 || col < 0)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                if (comand == "Add")
                {
                    matrix[row, col] += value;
                }
                else
                {
                    matrix[row, col] -= value;
                }
            }

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write(matrix[r, c] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
