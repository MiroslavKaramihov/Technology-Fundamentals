using System;

namespace P_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int partySize = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            decimal currCoins = 0;


            for (int i = 1; i <= days; i++)
            {

                if (i % 10 == 0)
                {
                    partySize -= 2;
                }
                if (i % 15 == 0)
                {
                    partySize += 5;
                }
                currCoins += 50m - (partySize * 2);
                if (i % 3 == 0)
                {
                    currCoins -= partySize * 3;
                }
                 if (i % 5 == 0)
                {
                    currCoins += 20 * partySize;
                    if (i % 3 == 0)
                    {
                        currCoins -= 2*partySize;
                    }
                }
            }

            Console.WriteLine($"{partySize} companions received {Math.Floor (currCoins/partySize)} coins each.");
            
        }
    }
}
