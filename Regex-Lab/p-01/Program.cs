using System;
using System.Text.RegularExpressions;

namespace p_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); 



            string patern = @"\b([A-Z][a-z]+)\s(?<lastName>[A-Z][a-z]+)\b";

            Regex regex = new Regex(patern);

            var coleect = regex.Matches(input);

            foreach (Match match in coleect)
            {
                Console.Write(match+" ");
            }
            Console.WriteLine();
        }
    }
}
