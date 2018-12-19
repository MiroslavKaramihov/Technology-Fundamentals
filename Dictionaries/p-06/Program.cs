using System;
using System.Linq;
using System.Collections.Generic;

namespace p_06
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> listResult = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" : ");

                if (input[0] == "end")
                {
                    break;
                }

                if (!listResult.ContainsKey(input[0]))
                {

                    listResult.Add(input[0], new List<string>());

                }
                listResult[input[0]].Add(input[1]);
            }

           var result = listResult.OrderByDescending(x => x.Value.Count);


            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
               var ne6tosi= kvp.Value.OrderBy(x=>x);
                foreach (var item in ne6tosi)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }

}
