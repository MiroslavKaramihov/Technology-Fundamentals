using System;

namespace p_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int curNum = 0;
            bool toe = false;

            for (int i = 1; i <= number; i++)
            {
                curNum = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                toe = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{curNum} -> {toe}");
                sum = 0;
                i = curNum;
            }

        }
    }
}
