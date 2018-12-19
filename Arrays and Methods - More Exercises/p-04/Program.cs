using System;
using System.Linq;
using System.Collections.Generic;

namespace p_04
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            int coursur = int.Parse(Console.ReadLine());
            long sum = 0;
            bool isTrue = false;
            int counter = 0;

            int counterIsTrue = 0;

            for (long i = 0; i <= input.Length - 1; i++)
            {
                if (coursur == input[i])
                {
                    counterIsTrue++;
                }
            }

            for (long i = 0; i <= input.Length - 1; i++)
            {
                sum += input[i];

                if (input[i] == coursur)
                {
                    counter++;
                }
                if (counter == counterIsTrue)
                {
                    break;
                }
            }
            if (counterIsTrue == 0)
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                Console.WriteLine(sum - coursur);
            }
            // j < input[input[coursur]]
        }
    }
}
