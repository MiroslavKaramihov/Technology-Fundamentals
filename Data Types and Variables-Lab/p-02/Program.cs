using System;

namespace p_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine($"{Math.PI * r * r:f12}");
        }
    }
}
