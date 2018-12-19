using System;
using System.Linq;
using System.Collections.Generic;

namespace p_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int copyNumber = number;

            int factorielSum = 0;

            while (number != 0)
            {
                int currNumb = number % 10;
                number /= 10;

                int factoriel = 1;

                for (int i = 1; i <= currNumb; i++)
                {
                    factoriel *= i;
                }
                factorielSum += factoriel;

            }
                if (copyNumber == factorielSum)
                {
                    Console.WriteLine("yes");
                    
                }
                else
                {
                    Console.WriteLine("no");
                    
                }
        }
    }
}
