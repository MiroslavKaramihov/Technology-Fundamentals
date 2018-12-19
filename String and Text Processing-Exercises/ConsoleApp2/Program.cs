using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            List<string> validWord = new List<string>();


            foreach (var item in input)
            {
                bool isValid = false;

                if (item.Length > 2 && item.Length < 17)
                {

                    for (int i = 0; i < item.Length; i++)
                    {
                        if (char.IsLetterOrDigit(item[i]) || item[i] == '-' || item[i] == '_')
                        {
                            isValid = true;
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }

                }

                if (isValid == true)
                {
                    validWord.Add(item);
                }
            }

            foreach (var item in validWord)
            {
                Console.WriteLine(item);
            }
        }
    }
}
