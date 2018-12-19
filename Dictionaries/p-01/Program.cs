using System;
using System.Collections.Generic;
using System.Linq;

namespace p_01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> input = Console.ReadLine().ToList();

            input.RemoveAll(x => x == ' ');

            Dictionary<char, int> list = new Dictionary<char, int>();

            for (int i = 0; i < input.Count; i++)
            {
                if (!list.ContainsKey(input[i]))
                {
                    list.Add(input[i], 0);
                }

                list[input[i]]++;
            }

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
