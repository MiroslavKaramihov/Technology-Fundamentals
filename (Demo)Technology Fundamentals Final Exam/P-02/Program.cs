using System;
using System.Text.RegularExpressions;

namespace P_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string replacetString = "";

            for (int i = 0; i < input.Length; i++)
            {
                char currnt =(char)(input[i] - 3);

                replacetString += currnt;
            }

            string[] secInput = Console.ReadLine().Split();
            string serchingSymbol = secInput[0];
            string replaceSunbol = secInput[1];
            var result = "";

            if (replacetString.Contains(serchingSymbol))
            {
                result = replacetString.Replace(serchingSymbol, replaceSunbol);
            }

            string pattern = @"[e-z{}|#\s]";
            Regex regex = new Regex(pattern);

            bool isValid = regex.IsMatch(result);

            if (isValid)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("This is not the book you are looking for.");
            }
        }
    }
}
