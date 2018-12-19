using System;
using System.Text.RegularExpressions;

namespace p_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string patern = @"\+359{1}(-| ){1}[2]{1}(\1)[\d]{3}(\1)[\d]{4}\b";

            var regex = new Regex(patern);

            var match = regex.Matches(input);

         
            Console.WriteLine(string.Join(", ",match));
            
           
        }
    }
}
