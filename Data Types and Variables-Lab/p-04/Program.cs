using System;

namespace p_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            int result = n / p;

            if (n % p == 0)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(result + 1);
            }
        }
    }
}
