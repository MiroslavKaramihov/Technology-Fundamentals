using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace p_05
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger firstNumb = BigInteger.Parse(Console.ReadLine());
            int secNumb = int.Parse(Console.ReadLine());

           var result = (firstNumb * secNumb).ToString();

            Console.WriteLine(result.ToString());
        }
    }
}
