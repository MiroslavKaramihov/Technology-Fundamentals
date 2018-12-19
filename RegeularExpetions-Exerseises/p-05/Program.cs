using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> list = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                list.Add(input);
            }

            List<int> counter = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                string pattern = @"[sSTtAaRr]";
                Regex regex = new Regex(pattern);
                var counterLengt = regex.Matches(list[i]);

                counter.Add(counterLengt.Count);
            }

            List<string> replasedList = new List<string>();

            for (int i = 0; i < list.Count; i++)
            {
                string replased = "";

                for (int k = 0; k < list[i].Length; k++)
                {
                    replased += (char)(list[i][k] - counter[i]);
                }

                replasedList.Add(replased);
            }

            string planetPattern = @"(?<=@)[A-Za-z]+";
            string popularionPatern = @"(?<=:)[0-9]+";
            string aOrDPattern = @"(?<=!)[A|D]";
            string soldirCount = @"(?<=->)[0-9]+";
            Regex planetRegex = new Regex(planetPattern);
            Regex populationRegex = new Regex(popularionPatern);
            Regex aOrDRegex = new Regex(aOrDPattern);
            Regex soldgerRegex = new Regex(soldirCount);

            List<string> atack = new List<string>();
            List<string> defend = new List<string>();
            List<string> validList = new List<string>();

            foreach (var item in replasedList)
            {
                var isPlanet = planetRegex.IsMatch(item);
                string planet = planetRegex.Match(item).Value;
                var isPopulation = populationRegex.IsMatch(item);
                string populatio = populationRegex.Match(item).Value;
                var isAorD = aOrDRegex.IsMatch(item);
                string ard = aOrDRegex.Match(item).Value;
                var isSodger = soldgerRegex.IsMatch(item);
                string soldeger = soldgerRegex.Match(item).Value;

                if (isPlanet && isPopulation && isAorD && isSodger)
                {
                    validList = item.Split('@', '-', '!', ':', '>', ' ').ToList();

                    if (validList[0] == planet && validList[1] == populatio && validList[2] == ard && validList[3] == soldeger)
                    {
                        string AorD = aOrDRegex.Match(item).Value;

                        if (AorD == "A")
                        {
                            atack.Add(planet);
                        }
                        else
                        {
                            defend.Add(planet);
                        }
                    }

                }
                validList.Clear();
            }

            Console.WriteLine($"Attacked planets: {atack.Count}");

            foreach (var item in atack.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");
            }

            Console.WriteLine($"Destroyed planets: {defend.Count}");

            foreach (var item in defend.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");
            }
        }
    }
}