using System;
using System.Collections.Generic;
using System.Linq;

namespace p_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split('-', '|').ToList();

            int currEnergy = 100;
            int currCoins = 100;




            for (int i = 0; i < input.Count; i++)
            {
                

                if (input[i] == "rest")
                {
                    int energy = int.Parse(input[i + 1]);

                    if (currEnergy + energy >= 100)
                    {
                        currEnergy = 100;
                        Console.WriteLine("You gained 0 energy.");
                        Console.WriteLine("Current energy: 100.");
                    }
                    else
                    {
                        currEnergy += energy;
                        Console.WriteLine($"You gained {energy} energy.");
                        Console.WriteLine($"Current energy: {currEnergy}.");
                    }

                }
                else if (input[i] == "order")
                {
                    currEnergy -= 30;

                    if (currEnergy >= 0)
                    {
                        int coins = int.Parse(input[i + 1]);
                        currCoins += coins;

                        Console.WriteLine($"You earned {coins} coins.");
                    }
                    else
                    {
                        Console.WriteLine($"You had to rest!");

                        currEnergy += 50+30;
                    }
                }
                else
                {
                    string product = input[i];
                    int prise = int.Parse(input[i + 1]);


                    if (currCoins-prise > 0)
                    {
                        currCoins -= prise;
                        Console.WriteLine($"You bought {product}.");
                    }
                    else
                    {
                        Console.WriteLine($"Closed! Cannot afford {product}.");
                        break;
                    }
                }

                input.RemoveAt(i);
                input.RemoveAt(i);
                i = -1;
                if (input.Count == 0)
                {
                    Console.WriteLine("Day completed!");
                    Console.WriteLine($"Coins: {currCoins}");
                    Console.WriteLine($"Energy: {currEnergy}");
                    break;
                }
            }
        }
    }
}
