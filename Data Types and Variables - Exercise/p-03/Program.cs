using System;

namespace p_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string townName = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            double squareKilo = double.Parse(Console.ReadLine());

            Console.WriteLine($"Town {townName} has population of {population} and area {squareKilo} square km.");
        }
    }
}
