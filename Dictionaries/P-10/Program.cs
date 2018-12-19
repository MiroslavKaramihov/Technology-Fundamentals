using System;
using System.Linq;
using System.Collections.Generic;

namespace P_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> usersPointResult = new Dictionary<string, int>();
            Dictionary<string, int> coursCount = new Dictionary<string, int>();

            while (true)
            {
                string[] input = Console.ReadLine().Split('-').ToArray();

                if (input[0] == "exam finished")
                {
                    break;
                }

                if (input[1] == "banned")
                {
                    if (usersPointResult.ContainsKey(input[0]))
                    {
                        usersPointResult.Remove(input[0]);
                    }
                }
                else
                {
                    string user = input[0];
                    string curse = input[1];
                    int points = int.Parse(input[2]);

                    if (!usersPointResult.ContainsKey(user))
                    {
                        usersPointResult.Add(user, 0);
                    }
                    if (points > usersPointResult[user])
                    {
                        usersPointResult[user] = points;
                    }
                    if (!coursCount.ContainsKey(curse))
                    {
                        coursCount.Add(curse, 0);
                    }
                    coursCount[curse]++;
                }
            }

            var result = usersPointResult.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

            Console.WriteLine("Results:");

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }

            Console.WriteLine("Submissions:");

            var result1 = coursCount.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

            foreach (var kvp in result1)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}
