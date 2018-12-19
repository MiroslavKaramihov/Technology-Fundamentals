using System;
using System.Text.RegularExpressions;

namespace p_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string patern = @"(\d{2})([.|\-|\/])([A-Za-z]{3})(\2)([0-9]{4})\b";

            Regex regex = new Regex(patern);

            var matches = regex.Matches(input);

            foreach (Match item in matches)
            {
                Console.WriteLine($"Day: {item.Groups[1]}, Month: {item.Groups[3]}, Year: {item.Groups[5]}");
            }
        }
    }
}
