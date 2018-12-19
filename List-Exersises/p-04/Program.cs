using System;
using System.Collections.Generic;
using System.Linq;

namespace p_04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            input.Remove("");

            List<long> listOfInt = input.Select(long.Parse).ToList();



            while (true)
            {
                string[] comands = Console.ReadLine().Split().ToArray();

                if (comands[0] == "End")
                {
                    break;
                }
                else if (comands[0] == "Add")
                {
                    long value = long.Parse(comands[1]);

                    listOfInt.Add(value);
                }
                else if (comands[0] == "Insert")
                {
                    long value = long.Parse(comands[1]);
                    int index = int.Parse(comands[2]);

                    if (index > listOfInt.Count - 1 || index<0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        listOfInt.Insert(index, value);
                    }

                }
                else if (comands[0] == "Remove")
                {
                    int index = int.Parse(comands[1]);

                    if (index > listOfInt.Count - 1 || index <0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        listOfInt.RemoveAt(index);
                    }

                }
                else if (comands[1] == "left")
                {
                    int count = int.Parse(comands[2]);
                    int currCount = 0;

                    if (count >= 0)
                    {
                        for (int i = 0; i < listOfInt.Count; i++)
                        {
                            long currIndex = listOfInt[i];

                            listOfInt.Add(currIndex);
                            listOfInt.Remove(currIndex);
                            i = -1;
                            currCount++;
                            if (currCount == count)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        break;
                    }


                }
                else
                {

                    int count = int.Parse(comands[2]);
                    int currCount = 0;
                    listOfInt.Reverse();

                    for (int i = 0; i < listOfInt.Count; i++)
                    {
                        long currIndex = listOfInt[i];

                        listOfInt.Add(currIndex);
                        listOfInt.Remove(currIndex);
                        i = -1;
                        currCount++;
                        if (currCount == count)
                        {
                            break;
                        }
                    }
                    listOfInt.Reverse();
                }

            }

            foreach (var item in listOfInt)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }



    }
}
