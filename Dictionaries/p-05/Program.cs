using System;
using System.Linq;
using System.Collections.Generic;


namespace p_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> list = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] inputCommand = Console.ReadLine().Split();

                string command = inputCommand[0];
                string name = inputCommand[1];

                if (command == "register")
                {
                    string registerNumber = inputCommand[2];

                    if (!list.ContainsKey(name))
                    {
                        list.Add(name, registerNumber);
                        Console.WriteLine($"{name} registered {registerNumber} successfully");
                    }
                    else if (list.ContainsKey(name))
                    {
                        foreach (var item in list)
                        {
                            if (item.Key == name)
                            {
                                Console.WriteLine($"ERROR: already registered with plate number {item.Value}");
                            }
                        }
                    }
                    

                }
                else
                {
                    if (list.ContainsKey(name))
                    {
                        list.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                }

            }

            foreach (var kvp in list)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
