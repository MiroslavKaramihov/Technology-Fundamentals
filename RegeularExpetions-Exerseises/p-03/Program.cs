using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace p_03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(", ").ToList();
            Dictionary<string, int> listOfRecers = new Dictionary<string, int>();


            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of race")
                {
                    break;
                }

                string namePattern = @"[A-Za-z+]";
                string numberPattern = @"[0-9]";

                Regex regexName = new Regex(namePattern);
                Regex regexNumber = new Regex(numberPattern);

                var nameColection = regexName.Matches(input);
                var numColection = regexNumber.Matches(input);

                int totalRun = 0;

                for (int i = 0; i < numColection.Count; i++)
                {
                    totalRun += int.Parse(numColection[i].Value);
                }


                string nextName = "";

                for (int i = 0; i < nameColection.Count; i++)
                {
                    nextName += nameColection[i];
                }

                if (names.Contains(nextName))
                {
                    if (!listOfRecers.ContainsKey(nextName))
                    {
                        listOfRecers.Add(nextName, 0);

                    }
                        listOfRecers[nextName] += totalRun;
                }
            }

            var result = listOfRecers.OrderByDescending(x => x.Value).ToList();

            int count = 0;

            foreach (var kvp in result)
            {
                count++;

                if (count==1)
                {
                    Console.WriteLine($"1st place: {kvp.Key}");
                }
                else if (count==2)
                {
                    Console.WriteLine($"2nd place: {kvp.Key}");
                }
                else
                {
                    Console.WriteLine($"3rd place: {kvp.Key}");
                }
                if (count==3)
                {
                    break;
                }
            }
        }

        class Racers
        {
            public string Name { get; set; }
            public int Runs { get; set; }
        }
    }
}
