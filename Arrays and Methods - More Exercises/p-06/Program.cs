using System;
using System.Linq;
using System.Collections.Concurrent;

namespace p_06
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] prices = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long jewelsPrice = prices[0];
            long goldPrice = prices[1];

            long goldCount = 0;
            long jewelCOunt = 0;
            long finalExp = 0;

            string endProces = "";

            while (endProces != "Jail")
            {
                string[] loot = Console.ReadLine().Split().ToArray();
                endProces = loot[0];

                if (endProces != "Jail")
                {
                    long currExpriance = long.Parse(loot[1]);
                    string diger = loot[0];
                    finalExp += currExpriance;

                    for (int i = 0; i <= diger.Length - 1; i++)
                    {
                        if (diger[i] == '%')
                        {
                            jewelCOunt++;
                        }
                        else if (diger[i] == '$')
                        {
                            goldCount++;
                        }
                    }
                }
            }
            long sumJ = jewelCOunt * jewelsPrice;
            long sumG = goldCount * goldPrice;
            long total = sumG + sumJ;

            if (total >= finalExp)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {total - finalExp}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {finalExp - total}.");
            }
        }
    }
}
