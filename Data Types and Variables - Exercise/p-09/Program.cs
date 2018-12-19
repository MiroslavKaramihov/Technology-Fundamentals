using System;

namespace p_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int copyN = n;

            int count = 0;
            int currResult = 0;

            while (true)
            {
                if (n < m)
                {
                    Console.WriteLine(n);
                    Console.WriteLine(count);
                    break;
                }
                n -= m;
                count++;


                if (copyN * 0.50 == n)
                {
                    if (n > y && y != 0)
                    {
                        n = Math.Abs(n / y);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}
