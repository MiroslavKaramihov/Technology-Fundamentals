using System;

namespace p_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int centure = int.Parse(Console.ReadLine());

            int years = centure * 100;
            int days = (int)(years * 365.2422);
            int houurs = days * 24;
            int min = houurs * 60;

            Console.WriteLine($"{centure} centuries = {years} years = {days} days = {houurs} hours = {min} minutes");
        }
    }
}
