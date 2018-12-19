using System;
using System.Collections.Generic;
using System.Linq;

namespace p_01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            input.Sort();
            double minValiu = input[0];
            double maxValiu = input[input.Count - 1];
            double averValue = 0;
            double sum = 0;

            for (int i = 0; i <= input.Count - 1; i++)
            {
                sum += input[i];
            }

            averValue = (sum / input.Count);

            Console.WriteLine($"Min = {minValiu}");
            Console.WriteLine($"Max = {maxValiu}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {averValue}");
        }
    }
}
