using System;

namespace p_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal result = 0m;

            for (int i = 0; i < n; i++)
            {
                decimal curNum = decimal.Parse(Console.ReadLine());

                result += curNum;
            }
            Console.WriteLine(result);
        }
    }
}
