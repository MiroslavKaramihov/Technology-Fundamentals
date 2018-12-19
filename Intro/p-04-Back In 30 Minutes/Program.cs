using System;

namespace p_04_Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minets = int.Parse(Console.ReadLine())+30;

            if (minets>59)
            {
                minets -= 60;
                hours++;
            }
            if (hours>23)
            {
                hours = 0;
            }
            Console.WriteLine($"{hours}:{minets:d2}");
        }
    }
}
