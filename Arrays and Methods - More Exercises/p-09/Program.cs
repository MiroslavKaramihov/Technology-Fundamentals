using System;
using System.Linq;
using System.Collections.Generic;

namespace p_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int currPos = 0;
            int index = 0;
            int sum = 0;
            bool end = false;

            while (true)
            {

                index = currPos;
                currPos += input[index];
                sum += input[index];

                if (currPos >= 0 && currPos < input.Length)
                {

                }
                else
                {
                    currPos -= input[index];
                    currPos -= input[currPos];
                    if (currPos < 0)
                    {
                        Console.WriteLine(sum);
                        break;
                    }
                }
            }

        }
    }
}
