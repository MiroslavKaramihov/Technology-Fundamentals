using System;
using System.Collections.Generic;
using System.Linq;

namespace p_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            int length = int.Parse(Console.ReadLine());
            int count = 0;
            string[] list = new string[10];

            for (int i = 0; i <= input.Length - 1; i++)
            {
                if (input[i].Length == length)
                {
                    Console.WriteLine($"Adding {input[i]}.");
                    list[i] = input[i];
                    count++;
                    if (count == 10)
                    {
                        break;
                    }
                }
            }

            string[] newString = new string[count];
            int index = 0;

            for (int i = 0; i <= list.Length - 1; i++)
            {
                if (list[i] != null)
                {
                    newString[index] = list[i];
                    index++;
                }
            }

            Console.WriteLine($"Made pizza with total of {count} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ", newString)}.");
        }
    }
}
