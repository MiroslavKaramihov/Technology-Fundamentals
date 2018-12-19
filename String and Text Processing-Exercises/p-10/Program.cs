using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p_10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (var item in input)
            {
                if (item.Length < 20 || item.Length > 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    int halfPast = item.Length / 2;
                    int leftCountA = 0;
                    int leftCountHash = 0;
                    int leftCountDolar = 0;
                    int leftCountChovka = 0;

                    for (int i = 0; i < 10; i++)
                    {
                        var currItem = item[i];

                        if (currItem == '^')
                        {
                            leftCountChovka++;
                        }
                        else if (currItem == '$')
                        {
                            leftCountDolar++;
                        }
                        else if (currItem == '#')
                        {
                            leftCountHash++;
                        }
                        else if (currItem == '@')
                        {
                            leftCountA++;
                        }
                    }

                    int rithgCountA = 0;
                    int rCountHash = 0;
                    int rCountDolar = 0;
                    int rCountChovka = 0;

                    for (int j = 10; j < 20; j++)
                    {
                        var currItem = item[j];

                        if (currItem == '^')
                        {
                            rCountChovka++;
                        }
                        else if (currItem == '$')
                        {
                            rCountDolar++;
                        }
                        else if (currItem == '#')
                        {
                            rCountHash++;
                        }
                        else if (currItem == '@')
                        {
                            rithgCountA++;
                        }
                    }
                    if (leftCountA == rithgCountA && leftCountA > 5)
                    {
                        if (leftCountA == 10)
                        {
                            Console.WriteLine($"ticket \"{item}\" - 10@ Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{item}\" - {leftCountA}@");
                        }
                    }
                    else if (leftCountChovka == rCountChovka && leftCountChovka > 5)
                    {
                        if (leftCountChovka == 10)
                        {
                            Console.WriteLine($"ticket \"{item}\" - 10^ Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{item}\" - {leftCountChovka}^");
                        }
                    }
                    else if (leftCountDolar == rCountDolar && leftCountDolar > 5)
                    {
                        if (leftCountDolar == 10)
                        {
                            Console.WriteLine($"ticket \"{item}\" - 10$ Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{item}\" - {leftCountDolar}$");
                        }
                    }
                    else if (leftCountHash == rCountHash && leftCountHash > 5)
                    {
                        if (leftCountHash == 10)
                        {
                            Console.WriteLine($"ticket \"{item}\" - 10# Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{item}\" - {leftCountHash}#");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{item}\" - no match");
                    }
                }

            }
        }
    }
}
