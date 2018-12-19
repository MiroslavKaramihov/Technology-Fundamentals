using System;
using System.Collections.Generic;
using System.Linq;

namespace P_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> keyValuePairs = new Dictionary<string, List<string>>();

            string[] input = Console.ReadLine().Split(" | ");

            for (int i = 0; i < input.Length; i++)
            {
                string[] currentStrin = input[i].Split(": ");
                string word = currentStrin[0];
                string definition = currentStrin[1];

                if (!keyValuePairs.ContainsKey(word))
                {
                    keyValuePairs.Add(word, new List<string>());
                }

                keyValuePairs[word].Add(definition);
            }

            string[] secondInput = Console.ReadLine().Split(" | ");



            for (int i = 0; i < secondInput.Length; i++)
            {
                string printWord = secondInput[i];

                foreach (var item in keyValuePairs)
                {
                    if (item.Key == printWord)
                    {
                        var result = item.Value.OrderByDescending(x => x.Length);

                        Console.WriteLine(item.Key);

                        foreach (var kvp in result)
                        {
                            Console.WriteLine($" -{kvp}");
                        }
                    }
                }
            }

            string thrdInput = Console.ReadLine();

            if (thrdInput=="List")
            {
                var result = keyValuePairs.OrderBy(x => x.Key);

                foreach (var item in result)
                {
                    Console.Write($"{item.Key} ");
                }
                Console.WriteLine();
                return;
            }
            else
            {
                return;
            }
        }
    }
}
