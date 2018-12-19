using System;
using System.Collections.Generic;
using System.Linq;

namespace p_06
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPerson = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secoundPerson = Console.ReadLine().Split().Select(int.Parse).ToList();




            int minCount = Math.Min(firstPerson.Count, secoundPerson.Count);

            for (int i = 0; i < minCount; i++)
            {
                if (firstPerson[i] > secoundPerson[i])
                {
                    firstPerson.Add(firstPerson[i]);
                    firstPerson.Add(secoundPerson[i]);

                    firstPerson.Remove(firstPerson[i]);
                    secoundPerson.Remove(secoundPerson[i]);
                }

                else if (firstPerson[i] < secoundPerson[i])
                {
                    secoundPerson.Add(secoundPerson[i]);
                    secoundPerson.Add(firstPerson[i]);

                    secoundPerson.Remove(secoundPerson[i]);
                    firstPerson.Remove(firstPerson[i]);
                }

                else
                {
                    firstPerson.Remove(firstPerson[i]);
                    secoundPerson.Remove(secoundPerson[i]);
                }
                i = -1;
                minCount = Math.Min(firstPerson.Count, secoundPerson.Count);
            }

            if (firstPerson.Count>secoundPerson.Count)
            {
                Console.WriteLine($"First player wins! Sum: {firstPerson.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secoundPerson.Sum()}");
            }
        }
    }
}
