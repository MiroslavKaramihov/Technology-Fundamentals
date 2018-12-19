using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace p_02
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Item> result = new List<Item>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Purchase")
                {
                    break;
                }

                string pattern = @"^>>([A-Z+a-z+]+\s?[A-Z+a-z]+)<<([0-9]*\.?[0-9]+?)!([0-9]+)$";
                Regex regex = new Regex(pattern);
                var matches = regex.Matches(input);

                if (matches.Count == 0)
                {
                    continue;
                }

                Item item = new Item();
                foreach (Match match in matches)
                {
                    item.Name = match.Groups[1].Value;
                    item.Prise = decimal.Parse(match.Groups[2].Value);
                    item.Quantyty = int.Parse(match.Groups[3].Value);
                }

                result.Add(item);
            }

            decimal spends = 0;
            decimal price = 0;
            int quantiti = 0;



            foreach (var item in result)
            {
                price = item.Prise;
                quantiti = item.Quantyty;

                spends += price * quantiti;
            }

            Console.WriteLine("Bought furniture:");

            foreach (var item in result)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine($"Total money spend: {spends:f2}");

        }

        class Item
        {
            public string Name { get; set; }
            public decimal Prise { get; set; }
            public int Quantyty { get; set; }
        }
    }
}
