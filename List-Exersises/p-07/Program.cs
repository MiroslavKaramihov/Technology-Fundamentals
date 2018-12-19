using System;
using System.Collections.Generic;
using System.Linq;

namespace p_07
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            int count = 0;

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] =='|')
                {
                    count++;
                }
            }

            int delimiter = count / 2;

            List<int> list = new List<int>();

            int delCount = 0;

            for (int i = list.Count - 1; i >= 0; i--)
            {
                list.Add(input[i]);

                if (input[i]=='|')
                {
                    delCount++;
                }
                if (delCount==delimiter)
                {
                    break;
                }
            }
        }
    }
}
