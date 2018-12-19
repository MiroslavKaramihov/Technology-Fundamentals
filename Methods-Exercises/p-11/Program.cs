using System;
using System.Collections.Generic;
using System.Linq;

namespace p_11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                List<string> comands = Console.ReadLine().Split().ToList();

                if (comands[0] == "end")
                {
                    break;
                }

                else if (comands[0] == "exchange")
                {
                    int index = int.Parse(comands[1]);

                    if (index > list.Count - 1)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        list = Exchendge(list, index);
                        //  Console.WriteLine(string.Join(" ", list));
                    }
                }
                else if (comands[0] == "max")
                {
                    if (comands[1] == "even")
                    {
                        MaxEven(list);
                    }
                    else
                    {
                        MaxOdd(list);
                    }
                }
                else if (comands[0] == "min")
                {
                    if (comands[1] == "even")
                    {
                        MinEven(list);
                    }
                    else
                    {
                        MinOdd(list);
                    }
                }
                else if (comands[0] == "first")
                {
                    if (comands[2] == "even")
                    {
                        int numbers = int.Parse(comands[1]);

                        TakeFirstEvenElelments(list, numbers);
                    }
                    else
                    {
                        
                        int numbers = int.Parse(comands[1]);

                        TakeFirstOddElelments(list, numbers);
                    }
                }else
                {
                    if (comands[2]=="even")
                    {
                        int numbers = int.Parse(comands[1]);
                        TakeLastEvenElement(list, numbers);
                    }
                    else
                    {
                        int numbers = int.Parse(comands[1]);
                        TakeLastOddElements(list,numbers);
                    }
                }

            }
        }

        private static void TakeLastOddElements(List<int> list, int numbers)
        {
            list.Reverse();
            int count = 0;

            List<int> newList = new List<int>();

            if (numbers > list.Count - 1)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 == 1)
                    {
                        newList.Add(list[i]);
                        count++;
                        if (count == numbers)
                        {
                            break;
                        }
                    }
                }
                newList.Reverse();
                Console.WriteLine($"[{string.Join(", ", newList)}]");
            }
        }

        private static void TakeLastEvenElement(List<int> list, int numbers)
        {
            list.Reverse();
            int count = 0;

            List<int> newList = new List<int>();

            if (numbers > list.Count - 1)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 == 0)
                    {
                        newList.Add(list[i]);
                        count++;
                        if (count == numbers)
                        {
                            break;
                        }
                    }
                }
                newList.Reverse();
                Console.WriteLine($"[{string.Join(", ", newList)}]");
            }
        }

        private static void TakeFirstOddElelments(List<int> list, int numbers)
        {
            int count = 0;

            List<int> newList = new List<int>();

            if (numbers > list.Count - 1)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 == 1)
                    {
                        newList.Add(list[i]);
                        count++;
                        if (count == numbers)
                        {
                            break;
                        }
                    }
                }
                Console.WriteLine($"[{string.Join(", ", newList)}]");
            }
        }

        private static void TakeFirstEvenElelments(List<int> list, int numbers)
        {
            int count = 0;

            List<int> newList = new List<int>();

            if (numbers > list.Count - 1)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 == 0)
                    {
                        newList.Add(list[i]);
                        count++;
                        if (count == numbers)
                        {
                            break;
                        }
                    }
                }
                Console.WriteLine($"[{string.Join(", ", newList)}]");
            }

        }

        private static void MinOdd(List<int> list)
        {
            int minValue = int.MaxValue;
            int minIndex = 0;
            int currValue = 0;
            int currIndex = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 1)
                {
                    currValue = list[i];
                    currIndex = i;
                    if (currValue <= minValue)
                    {
                        minValue = currValue;
                        minIndex = currIndex;
                    }
                }

            }
            if (minValue == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{minIndex}");
            }
        }

        private static void MinEven(List<int> list)
        {
            int minValue = int.MaxValue;
            int minIndex = 0;
            int currValue = 0;
            int currIndex = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    currValue = list[i];
                    currIndex = i;
                    if (currValue <= minValue)
                    {
                        minValue = currValue;
                        minIndex = currIndex;
                    }
                }

            }
            if (minValue == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{minIndex}");
            }
        }

        private static void MaxOdd(List<int> list)
        {
            int maxValue = int.MinValue;
            int maXIndex = 0;
            int currValue = 0;
            int currIndex = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 1)
                {
                    currValue = list[i];
                    currIndex = i;
                    if (currValue >= maxValue)
                    {
                        maxValue = currValue;
                        maXIndex = currIndex;
                    }
                }
            }


            if (maxValue == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{maXIndex}");
            }

        }

        private static void MaxEven(List<int> list)
        {
            int maxValue = int.MinValue;
            int maXIndex = 0;
            int currValue = 0;
            int currIndex = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    currValue = list[i];
                    currIndex = i;
                    if (currValue >= maxValue)
                    {
                        maxValue = currValue;
                        maXIndex = currIndex;
                    }
                }
            }

            if (maxValue == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{maXIndex}");
            }

        }

        private static List<int> Exchendge(List<int> list, int index)
        {

            for (int i = 0; i <= index; i++)
            {
                list.Add(list[i]);
            }

            int count = 0;

            for (int i = 0; i <= index; i++)
            {
                list.RemoveAt(i);
                i = -1;
                count++;
                if (count == index + 1)
                {
                    break;
                }
            }
            return list;
        }
    }
}
