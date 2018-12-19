using System;
using System.Linq;
using System.Collections.Generic;

namespace p_04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> input = Console.ReadLine().Select(x=>x=(char)(x+3)).ToList();

            Console.WriteLine(string.Join("",input));
        }
    }
}
