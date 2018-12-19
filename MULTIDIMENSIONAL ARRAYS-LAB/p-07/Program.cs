using System;
using System.Linq;

namespace p_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagetArray = new int[3][];

            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            jagetArray[0] = input.Where(x => x % 3 == 0).ToArray();
            jagetArray[1] = input.Where(x => x % 3 == 1 || x % 3 == -1).ToArray();
            jagetArray[2] = input.Where(x => x % 3 == 2 || x % 3 == -2).ToArray();

            for (int i = 0; i < jagetArray.Length; i++)
            {
                Console.WriteLine(string.Join(" ",jagetArray[i]));
            }
        }
    }
}
