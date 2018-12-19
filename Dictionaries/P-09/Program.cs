using System;
using System.Collections.Generic;
using System.Linq;

namespace P_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> list = new Dictionary<string, List<string>>();

            while (true)
            {
                string stri = Console.ReadLine();

                bool isExistPipe = stri.Contains("|");
                bool isExistStrelka = stri.Contains("->");

                string[] input = stri.Split(new char[] { '|', '-', '>', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "Lumpawaroo")
                {
                    break;
                }



                else if (isExistPipe)
                {
                    string forceSide = input[0];
                    string user = input[1];
                    forceSide = forceSide.TrimEnd(' ');
                    user = user.TrimEnd(' ');
                    forceSide = forceSide.TrimStart(' ');
                    user = user.TrimStart(' ');

                    if (!list.ContainsKey(forceSide))
                    {
                        list.Add(forceSide, new List<string>());
                        list[forceSide].Add(user);
                    }
                    else
                    {
                        list[forceSide].Add(user);
                    }
                }
                else
                {
                    string user = input[0];
                    string forceSide = input[1];

                    forceSide = forceSide.TrimEnd(' ');
                    user = user.TrimEnd(' ');
                    forceSide = forceSide.TrimStart(' ');
                    user = user.TrimStart(' ');

                    bool isExist = false;
                    string curentTeam = "";

                    foreach (var item in list)
                    {
                        foreach (var kvp in item.Value)
                        {
                            if (kvp == user)
                            {
                                curentTeam = item.Key;
                                isExist = true;
                            }
                        }
                    }

                    if (isExist == true)
                    {
                        list[curentTeam].Remove(user);
                        list[forceSide].Add(user);

                        Console.WriteLine($"{user} joins the {forceSide} side!");
                    }
                    else if (!list.ContainsKey(forceSide))
                    {
                        list.Add(forceSide, new List<string>());
                        list[forceSide].Add(user);
                        Console.WriteLine($"{user} joins the {forceSide} side!");
                    }
                    else
                    {
                        list[forceSide].Add(user);
                        Console.WriteLine($"{user} joins the {forceSide} side!");

                    }

                }
            }

            var result = list.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key);

            foreach (var kvp in result)
            {
                if (kvp.Value.Count != 0)
                {
                    Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");

                    var resultMeber = kvp.Value.OrderBy(x => x);

                    foreach (var item in resultMeber)
                    {
                        Console.WriteLine("! " + item);
                    }


                }
            }
        }
    }
}
