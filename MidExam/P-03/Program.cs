using System;
using System.Collections.Generic;
using System.Linq;

namespace P_03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split('|', ' ').ToList();




            int countRoom = 0;
            int currHealt = 100;
            decimal coins = 0;

            for (int i = 0; i < input.Count; i++)
            {
                string comand = input[i];
                int number = int.Parse(input[i + 1]);
                countRoom ++;

                if (comand == "potion")
                {


                    if (100 < currHealt + number)
                    {
                        Console.WriteLine($"You healed for {100 - currHealt} hp.");
                        Console.WriteLine($"Current health: 100 hp.");
                        currHealt = 100;
                    }
                    else
                    {
                        currHealt += number;

                        Console.WriteLine($"You healed for {number} hp.");
                        Console.WriteLine($"Current health: {currHealt} hp.");
                    }

                }
                else if (comand == "chest")
                {
                    coins += number;

                    Console.WriteLine($"You found {number} coins.");
                }
                else
                {
                    currHealt -= number;

                    if (currHealt > 0)
                    {
                        Console.WriteLine($"You slayed {comand}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {comand}.");
                        Console.WriteLine($"Best room: {countRoom}");
                        break;
                    }
                }

                input.RemoveAt(i);
                input.RemoveAt(i);

                i = -1;


                if (input.Count == 0)
                {
                    Console.WriteLine($"You've made it!");
                    Console.WriteLine($"Coins: {coins}");
                    Console.WriteLine($"Health: {currHealt}");
                    break;

                }
            }

        }
    }
}
