using System;

namespace p_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= n - 1; j++)
                {
                    for (int k = 0; k <= n - 1; k++)
                    {
                        Console.WriteLine($"{(char)('a' + i)}{(char)('a' + j)}{(char)('a' + k)}");
                    }
                }
            }
        }
    }
}
