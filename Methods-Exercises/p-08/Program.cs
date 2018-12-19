using System;
using System.Numerics;

namespace p_08
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger firstNum = BigInteger.Parse(Console.ReadLine());
            BigInteger secundNum = BigInteger.Parse(Console.ReadLine());

            BigInteger firstFact = FactorielResult(firstNum);
            BigInteger secFact = FactorielResult(secundNum);

            BigInteger result = firstFact / secFact;

            Console.WriteLine($"{result:f2}");
        }

        private static BigInteger FactorielResult(BigInteger num)
        {
           
            
                if (num <= 1)
                {
                    return 1;
                }
                BigInteger result = 1;
                try
                {
                    for (int i = 1; i <= num; i++)
                    {
                        result = checked(result * i);
                    }
                }
                catch (OverflowException)
                {
                    return 0;
                }
                return result;
            
        }
    }
}
