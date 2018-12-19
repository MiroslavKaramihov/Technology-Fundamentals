using System;

namespace p_01
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int studentsNum = int.Parse(Console.ReadLine());
            decimal flourPrice = decimal.Parse(Console.ReadLine());
            decimal eggPrice = decimal.Parse(Console.ReadLine());
            decimal apronPrice = decimal.Parse(Console.ReadLine());

            decimal eggTotalPrise = studentsNum * (eggPrice * 10.00m);
            decimal apronTotalPrice =studentsNum * 0.20m;
            apronTotalPrice = Math.Ceiling((apronTotalPrice)+studentsNum)*apronPrice;

            decimal florFree = Math.Floor(studentsNum / 5m);

            decimal florTotalPrice = (studentsNum - florFree) * flourPrice;


            decimal result = florTotalPrice + eggTotalPrise + apronTotalPrice;


            if (budget>=result)
            {
                Console.WriteLine($"Items purchased for {result:f2}$.");
            }
            else
            {
                Console.WriteLine($"{result-budget:f2}$ more needed.");
            }

        }
    }
}
