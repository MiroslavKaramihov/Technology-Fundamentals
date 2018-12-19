using System;
using System.Text.RegularExpressions;

namespace p_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\b([a-zA-Z0-9]+)([_\.\-\]?)@([a-z_\-\.]+)\.([a-z]+)\b";
            Regex regex = new Regex(pattern);

            var emailMatch = regex.Matches(input);

            foreach (Match match in emailMatch)
            {
                Console.WriteLine(match);
            }
        }
    }
}
