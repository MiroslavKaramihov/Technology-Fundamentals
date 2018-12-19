using System;
using System.Linq;
using System.Collections.Generic;

namespace p_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> producktQuantyti = new Dictionary<string, int>();
            Dictionary<string, decimal> producktPrice = new Dictionary<string, decimal>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "buy")
                {
                    break;
                }

                string[] tokens = input.Split();

                string product = tokens[0];
                decimal price = decimal.Parse(tokens[1]);
                int quantity = int.Parse(tokens[2]);

                if (producktPrice.ContainsKey(product)==false)
                {
                    producktPrice[product] = price;
                    producktQuantyti[product] = quantity;
                }
                else
                {
                    producktPrice[product] = price;
                    producktQuantyti[product] += quantity;
                }

            }

            foreach (var kvp in producktQuantyti)
            {
                string produckt = kvp.Key;
                int quantyti = kvp.Value;
                decimal price = producktPrice[produckt];
                decimal result = quantyti * price;

                Console.WriteLine($"{produckt} -> {result:f2}");
            }
        }
    }
}
