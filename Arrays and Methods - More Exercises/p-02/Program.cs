using System;
using System.Collections.Generic;
using System.Linq;

namespace p_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> array = Console.ReadLine().Split().ToList();
            int countComand = int.Parse(Console.ReadLine());
            int counter = 0;

            while (countComand != counter)
            {
                string[] comands = Console.ReadLine().Split().ToArray();

                if (comands[0] == "Replace")
                {
                    int index = int.Parse(comands[1]);

                    array.RemoveAt(index);
                    array.Insert(index, comands[2]);
                }
                else if (comands[0] == "Distinct")
                {
                    List<string> newArr = array.Distinct().ToList();

                    

                    for (int i = 0; i <= newArr.Count-1; i++)
                    {
                        array[i] = newArr[i];
                    }

                    array = newArr.Distinct().ToList();
                }

                else if (comands[0] == "Reverse")
                {
                    array.Reverse();
                }

                counter++;
            }
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
