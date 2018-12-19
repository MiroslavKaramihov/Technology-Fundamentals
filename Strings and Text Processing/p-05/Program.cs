using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace p_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<char> letters = new List<char>();
            List<char> digits = new List<char>();
            List<char> other = new List<char>();


            for (int i = 0; i < input.Length; i++)
            {
                char curentChar = input[i];
               

                if (char.IsDigit(curentChar))
                {
                    digits.Add(curentChar);
                }
                else if (char.IsLetter(curentChar))
                {
                    letters.Add(curentChar);
                }
                else
                {
                    other.Add(curentChar);
                }
            }

            foreach (var item in digits)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            foreach (var item in letters)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            foreach (var item in other)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
