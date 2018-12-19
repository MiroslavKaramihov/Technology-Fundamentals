using System;
using System.Text.RegularExpressions;

namespace p_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\b(?:0x)?[0-9A-F]+\b";

            var regex = new Regex(pattern);

            var match = regex.Matches(input);

            Console.Write(string.Join(" ",match));
            Console.ReadLine();
        }
    }
}
