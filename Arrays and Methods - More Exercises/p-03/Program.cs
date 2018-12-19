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
            //int countComand = int.Parse(Console.ReadLine());
            string counter = "";

            while (true)
            {
                string[] comands = Console.ReadLine().Split().ToArray();
                counter = comands[0];

                if (counter == "END")
                {
                    break;
                }
                if (comands[0] == "Replace")
                {
                    int index = int.Parse(comands[1]);
                    if (index >= 0 && index <= array.Count-1)
                    {
                        array.RemoveAt(index);
                        array.Insert(index, comands[2]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }

                }
                else if (comands[0] == "Distinct")
                {
                    List<string> newArr = array.Distinct().ToList();



                    for (int i = 0; i <= newArr.Count - 1; i++)
                    {
                        array[i] = newArr[i];
                    }

                    array = newArr.Distinct().ToList();
                }

                else if (comands[0] == "Reverse")
                {
                    array.Reverse();
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

            }
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
