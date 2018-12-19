using System;
using System.Linq;
using System.Collections.Concurrent;

namespace p_08
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split().ToArray();
            long[] quantities = Console.ReadLine().Split().Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            while (true)
            {
                string[] comand = Console.ReadLine().Split().ToArray();

                if (comand[0] == "done")
                {
                    break;
                }

                long currQuantite = long.Parse(comand[1]);

                for (int i = 0; i <= names.Length - 1; i++)
                {
                    if (comand[0] == names[i])
                    {
                        try
                        {
                           // if (quantities[i] <= quantities.Length - 1)
                            {

                                if (quantities[i] >= currQuantite)
                                {
                                    Console.WriteLine($"{names[i]} x {currQuantite} costs {currQuantite * prices[i]:f2}");
                                    quantities[i] -= currQuantite;
                                }
                                else
                                {
                                    Console.WriteLine($"We do not have enough {names[i]}");
                                }
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"We do not have enough {names[i]}");
                        }
                    }
                }
            }
        }
    }
}
