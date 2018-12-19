using System;
using System.Collections.Generic;
using System.Linq;

namespace p_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int bestSum = 0;
            double bestAvg = 0;
            var bestList = new List<int>();


            while (true)
            {
                List<string> input = Console.ReadLine().Split('#').ToList();

                if (input[0] == "Bake It!")
                {
                    break;
                }

                List<int> list = input.Select(int.Parse).ToList();

                var currSum = list.Sum();
                var currAvg = list.Average();

                if (currSum > bestSum)
                {
                    bestSum = currSum;

                    if (currAvg > bestAvg)
                    {
                        bestAvg = currAvg;

                        if (list.Count > bestList.Count)
                        {
                            bestList = list;

                        }
                    }
                }

            }

            Console.WriteLine($"Best Batch quality: {bestSum}");
            Console.WriteLine(string.Join(" ", bestList));

        }
    }
}
