using System;
using System.Linq;

namespace p_07
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split().ToArray();
            long[] quantities = Console.ReadLine().Split().Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            while (true)
            {
                string comand = Console.ReadLine();

                if (comand == "done")
                {
                    break;
                }

                for (int i = 0; i <= names.Length - 1; i++)
                {
                    if (comand == names[i])
                    {
                        Console.WriteLine($"{names[i]} costs: {prices[i]}; Available quantity: {quantities[i]}");
                    }
                }
            }
        }
    }
}
