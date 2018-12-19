using System;
using System.Collections.Generic;
using System.Linq;

namespace p_01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            int maxLength = 0;
            int index = 0;

            for (int i = 0; i < list.Count - 1; i++)
            {
                int currLength = 0;

                for (int j = i; j < list.Count; j++)
                {
                    if (list[i] == list[j])
                    {
                        currLength++;
                        if (currLength > maxLength)
                        {
                            maxLength = currLength;
                            index = list[i];
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            for (int i = 0; i < maxLength; i++)
            {
                Console.Write(index + " ");
            }
            Console.WriteLine();
        }
    }
}
