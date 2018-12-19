using System;

namespace p_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int lastDigit = 0;
                int sum = 0;
                int curNum = i;
                while (true)
                {
                    lastDigit = curNum % 10;
                    sum += lastDigit;
                    curNum = curNum / 10;

                    if (curNum == 0)
                    {
                        break;
                    }
                }
                if (sum == 5 || sum == 7 | sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
