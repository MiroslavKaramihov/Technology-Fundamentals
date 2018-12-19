using System;
using System.Collections.Generic;
using System.Linq;

namespace p_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listInput = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                List<string> comands = Console.ReadLine().Split().ToList();

                if (comands[0] == "Delete")
                {
                    int number = int.Parse(comands[1]);

                    for (int i = 0; i <= listInput.Count-1; i++)
                    {
                        if (listInput[i] == number)
                        {
                            listInput.Remove(listInput[i]);
                            i = -1;
                        }
                    }

                }
                else if (comands[0] == "Insert")
                {
                    int value = int.Parse(comands[1]);
                    int index = int.Parse(comands[2]);

                    listInput.Insert(index, value);
                }
                else if (comands[0] == "Even")
                {
                    for (int i = 0; i <= listInput.Count-1; i++)
                    {
                        if (listInput[i] % 2 == 0)
                        {
                            Console.Write(listInput[i] + " ");
                        }
                    }
                    Console.WriteLine();
                    break;
                }
                else if(comands[0] == "Odd")
                {
                    for (int i = 0; i <= listInput.Count-1; i++)
                    {
                        if (listInput[i] % 2 == 1)
                        {
                            Console.Write(listInput[i] + " ");
                        }
                    }
                    Console.WriteLine();
                    break;
                }
            }
        }
    }
}
