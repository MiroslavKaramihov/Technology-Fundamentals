using System;
using System.Linq;
using System.Collections.Generic;

namespace p_01
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phoneBoock = new SortedDictionary<string, string>();

            while (true)
            {
                List<string> input = Console.ReadLine().Split().ToList();

                string comand = input[0];

                if (comand == "END")
                {
                    break;
                }

                else if (comand == "A")
                {
                    string name = input[1];
                    string number = input[2];
                    phoneBoock[name] = number;


                }
                else if (comand == "S")
                {
                    string name = input[1];




                    if (phoneBoock.ContainsKey(name) == true)
                    {
                        Console.WriteLine($"{name} -> {phoneBoock[name]}");


                    }

                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                else if (comand=="ListAll")
                {
                    foreach (var item in phoneBoock)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }
            }
        }
    }
}
