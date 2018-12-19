using System;
using System.Collections.Generic;
using System.Linq;

namespace p_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new Dictionary<string, int>();

            while (true)
            {
                string resurs = Console.ReadLine();

                if (resurs=="stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

                if (!list.ContainsKey(resurs))
                {
                    list.Add(resurs, 0);
                }

                list[resurs] += quantity;
            }

            foreach (var kvp in list)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
