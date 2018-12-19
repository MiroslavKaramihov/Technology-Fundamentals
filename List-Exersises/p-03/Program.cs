using System;
using System.Collections.Generic;
using System.Linq;

namespace p_03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

            int cout = 0;

            List<int> newList = new List<int>(secondList[0]);

            for (int i = 0; i < secondList[0]; i++)
            {
                newList.Add(firstList[i]);
            }

            int cou = 0;

            for (int i = 0; i <= 1000; i++)
            {
                newList.RemoveAt(i);
                i = -1;
                cou++;
                if (cou == secondList[1])
                {
                    break;
                }
            }



            if (newList.Contains(secondList[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
