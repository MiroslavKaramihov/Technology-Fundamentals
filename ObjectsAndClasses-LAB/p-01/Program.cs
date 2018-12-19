using System;
using System.Globalization;

namespace p_01
{
    class Program
    {
        static void Main(string[] args)
        {

            var stringDate = Console.ReadLine();

           var input = DateTime.ParseExact(stringDate,"d-M-yyyy",CultureInfo.InvariantCulture);

            Console.WriteLine(input.DayOfWeek);
        }
    }
}
