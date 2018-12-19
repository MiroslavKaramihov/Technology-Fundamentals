using System;

namespace p_06
{
    class Program
    {
        static void Main(string[] args)
        {
            char fLine = char.Parse(Console.ReadLine());
            char sLine = char.Parse(Console.ReadLine());
            char tLine = char.Parse(Console.ReadLine());

            Console.WriteLine($"{tLine} {sLine} {fLine}");
        }
    }
}
