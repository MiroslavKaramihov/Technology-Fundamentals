using System;
using System.Collections.Generic;
using System.Linq;

namespace p_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(", ").ToList();

            while (true)
            {
                List<string> comandList = Console.ReadLine().Split(" - ").ToList();

                if (comandList[0]== "Retire!")
                {
                    break;
                }

                if (comandList[0] == "Start")
                {
                    if (!input.Contains(comandList[1]))
                    {
                        input.Add(comandList[1]);
                    }
                }
                else if (comandList[0] == "Complete")
                {
                    if (input.Contains(comandList[1]))
                    {
                        input.Remove(comandList[1]);
                    }
                }
                else if (comandList[0]=="Side Quest")
                {
                    List<string> quests = comandList[1].Split(':').ToList();

                    if (input.Contains(quests[0]))
                    {
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (input[i]==quests[0])
                            {
                                if (!input.Contains(quests[1]))
                                {
                                    input.Insert(i + 1, quests[1]);
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (input.Contains(comandList[1]))
                    {
                        input.Add(comandList[1]);
                        input.Remove(comandList[1]);
                    }
                }
            }

            Console.WriteLine(string.Join(", ",input));
        }
    }
}
