using System;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;

namespace p_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> plyaersResult = new Dictionary<string, int>();
            Dictionary<string, List<string>> plyaersResult1 = new Dictionary<string, List<string>>();

           


            while (true)
            {
                List<string> input = Console.ReadLine().Split(new char[] { ':', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                int sum = 0;

                List<string> list = input.Distinct().ToList();
                string name = list[0];

                if (name == "JOKER")
                {
                    break;
                }
                else
                {
                    for (int i = 1; i <= list.Count - 1; i++)
                    {

                        int firstIndex = list[i].First();
                        int lastIndex = list[i].Last();

                        if (lastIndex == 'S')
                        {
                            switch (firstIndex)
                            {
                                case 'J':
                                    sum = 11 * 4;
                                    break;
                                case 'Q':
                                    sum = 12 * 4;
                                    break;
                                case 'K':
                                    sum = 13 * 4;
                                    break;
                                case 'A':
                                    sum = 15 * 4;
                                    break;

                            }
                            if (firstIndex != 'J' && firstIndex != 'Q' && firstIndex != 'K' && firstIndex != 'A')
                            {
                                int value = (int)(firstIndex - 48);

                                sum = value * 4;

                            }


                        }
                        else if (lastIndex == 'H')
                        {
                            firstIndex = list[i].First();
                            lastIndex = list[i].Last();


                            switch (firstIndex)
                            {
                                case 'J':
                                    sum = 11 * 3;
                                    break;
                                case 'Q':
                                    sum = 12 * 3;
                                    break;
                                case 'K':
                                    sum = 13 * 3;
                                    break;
                                case 'A':
                                    sum = 14 * 3;
                                    break;

                            }
                            if (firstIndex != 'J' && firstIndex != 'Q' && firstIndex != 'K' && firstIndex != 'A')
                            {
                                int value = (int)(firstIndex - 48);

                                sum = value * 3;

                            }

                        }
                        else if (lastIndex == 'D')
                        {
                            firstIndex = list[i].First();
                            lastIndex = list[i].Last();


                            switch (firstIndex)
                            {
                                case 'J':
                                    sum = 11 * 2;
                                    break;
                                case 'Q':
                                    sum = 12 * 2;
                                    break;
                                case 'K':
                                    sum = 13 * 2;
                                    break;
                                case 'A':
                                    sum = 14 * 2;
                                    break;

                            }
                            if (firstIndex != 'J' && firstIndex != 'Q' && firstIndex != 'K' && firstIndex != 'A')
                            {
                                int value = (int)(firstIndex - 48);

                                sum = value * 2;

                            }

                        }
                        else if (lastIndex == 'C')
                        {
                            firstIndex = list[i].First();
                            lastIndex = list[i].Last();



                            switch (firstIndex)
                            {
                                case 'J':
                                    sum = 11;
                                    break;
                                case 'Q':
                                    sum = 12;
                                    break;
                                case 'K':
                                    sum = 13;
                                    break;
                                case 'A':
                                    sum = 14;
                                    break;

                            }
                            if (firstIndex != 'J' && firstIndex != 'Q' && firstIndex != 'K' && firstIndex != 'A')
                            {
                                int value = (int)(firstIndex - 48);

                                sum = value;

                            }
                        }

                        if (plyaersResult.Keys.Contains(name) == false)
                        {
                            plyaersResult.Add(name, sum);
                        }
                        else
                        {
                            plyaersResult[name] += sum;
                        }
                    }
                }
            }
            foreach (var item in plyaersResult)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }

    }
}



