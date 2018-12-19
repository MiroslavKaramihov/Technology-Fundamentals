using System;
using System.Collections.Generic;
using System.Linq;

namespace p_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> listOfMiner = new Dictionary<string, long>();

            while (true)
            {
                string resurs = Console.ReadLine();
                if (resurs == "stop")
                {
                    break;
                }
                long countResurs = long.Parse(Console.ReadLine());

                if (listOfMiner.Keys.Contains(resurs) == false)
                {
                    listOfMiner.Add(resurs, countResurs);
                }
                else
                {
                    listOfMiner[resurs] += countResurs;
                }

            }
            foreach (var item in listOfMiner)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");

            }
        }
    }
}
