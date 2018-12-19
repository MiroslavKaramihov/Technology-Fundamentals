using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> bandList = new Dictionary<string, List<string>>();
            Dictionary<string, int> plaiListTIme = new Dictionary<string, int>();
            int totalTime = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "start of concert")
                {
                    break;
                }

                string[] splitedInput = input.Split(new char[] { ';', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string comand = splitedInput[0];
                string bandName = splitedInput[1].TrimStart(' ');

                if (comand == "Add")
                {

                    if (!bandList.ContainsKey(bandName))
                    {
                        bandList.Add(bandName, new List<string>());

                        for (int i = 2; i < splitedInput.Length; i++)
                        {
                            string actor = splitedInput[i].TrimStart();
                            if (!bandList[bandName].Contains(actor))
                            {
                                bandList[bandName].Add(actor);
                            }
                        }
                    }
                    else
                    {
                        for (int i = 2; i < splitedInput.Length; i++)
                        {
                            string actor = splitedInput[i].TrimStart();
                            if (!bandList[bandName].Contains(actor))
                            {
                                bandList[bandName].Add(actor);
                            }
                        }
                    }
                }
                else if (comand == "Play")
                {
                    int playTime = int.Parse(splitedInput[2]);


                    if (!plaiListTIme.ContainsKey(bandName))
                    {
                        plaiListTIme.Add(bandName, 0);
                    }
                    plaiListTIme[bandName] += playTime;
                    totalTime += playTime;
                }
            }

            Console.WriteLine($"Total time: {totalTime}");

            foreach (var item in plaiListTIme.OrderByDescending(x=>x.Value))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

            string input1 = Console.ReadLine();

            foreach (var item in bandList)
            {
                if (item.Key == input1)
                {
                    Console.WriteLine(item.Key);
                    for (int i = 0; i < item.Value.Count; i++)
                    {
                        Console.WriteLine($"=> { item.Value[i]}");
                    }
                }
            }

        }
    }
}
