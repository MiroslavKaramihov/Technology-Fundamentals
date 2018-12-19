using System;

namespace p_04
{
    class Program
    {
        static void Main(string[] args)
        {
            double metars = double.Parse(Console.ReadLine());

            double kilometars = metars / 1000;

            Console.WriteLine($"{kilometars:f2}");
        }
    }
}
