using System;
using System.Numerics;

namespace p_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            BigInteger n = 1;

            for (int i = 02; i <= input; i++)
            {
                n *= i;
            }

            Console.WriteLine(n);
        }
    }
}
