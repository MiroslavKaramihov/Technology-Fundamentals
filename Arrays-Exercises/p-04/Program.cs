using System;
using System.Collections.Generic;
using System.Linq;

namespace p_04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

                int curr = input[0];

            int coun = 0;

            for (int i = 0; i < n; i++)
            {

                input.Add(curr);

                curr = input[i + 1];
                input.Remove(input[i]);
                i = -1;
                coun++;
                if (coun==n)
                {
                    break;
                }
            }
            Console.WriteLine(string.Join(" ",input));
        }
    }
}
