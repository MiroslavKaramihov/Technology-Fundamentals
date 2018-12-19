using System;
using System.Linq;
using System.Collections.Generic;

namespace p_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> result = new List<int>();

            int curr = 0;


            for (int i = 0; i <= input.Length - 1; i++)
            {
                bool isTrue = false;
                for (int j = i+1; j <= input.Length - 1; j++)
                {
                    if (input[i] <= input[j])
                    {
                        isTrue = false;
                        break;
                    }
                    else
                    {
                        isTrue = true;
                    }
                    
                }
                if (isTrue == true)
                {
                    result.Add(input[i]);
                }
            }
            result.Add(input[input.Length-1]);
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
