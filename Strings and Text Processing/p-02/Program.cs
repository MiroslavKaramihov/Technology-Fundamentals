using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace p_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            foreach (var item in input)
            {
                int repeat = item.Length;

                for (int i = 0; i < repeat; i++)
                {
                    Console.Write(item);
                }
            }
            Console.WriteLine();
        }
    }
}
