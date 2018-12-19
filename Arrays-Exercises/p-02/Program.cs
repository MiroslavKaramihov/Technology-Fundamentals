using System;
using System.Linq;

namespace p_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split().ToArray();
            string[] secoundLine = Console.ReadLine().Split().ToArray();

            int max = Math.Max(firstLine.Length, secoundLine.Length);
            string[] result = new string[max];
            int min = Math.Min(firstLine.Length, secoundLine.Length);

            int counter = 0;

            for (int i = 0; i <= secoundLine.Length-1; i++)
            {
                for (int j = 0; j <= firstLine.Length-1; j++)
                {
                    if (firstLine[j] == secoundLine[i])
                    {
                        result[counter] = secoundLine[i];
                        counter++;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
