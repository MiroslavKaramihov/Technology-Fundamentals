using System;

namespace p_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sum = 0;
            int currNum = 0;

            while (true)
            {
                currNum = number % 10;
                sum += currNum;
                number = number / 10;
                if (number==0)
                {
                    Console.WriteLine(sum);
                    break;
                }
            }
        }
    }
}
