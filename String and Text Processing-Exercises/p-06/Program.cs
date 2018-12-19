using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p_06
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> input = Console.ReadLine().ToList();

            for (int i = 0; i < input.Count; i++)
            {
                if (i + 1 == input.Count)
                {
                    break;
                }

                if (input[i] == input[i + 1])
                {
                    input.RemoveAt(i);
                    i = -1;
                }

            }

            Console.WriteLine(string.Join("", input));

        }
    }
}
