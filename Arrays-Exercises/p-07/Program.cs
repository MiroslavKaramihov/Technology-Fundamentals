using System;
using System.Linq;

namespace p_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxLength = 0;
            int index = 0;
            int bestIndex = 0;

            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                int curentLength = 1;

                for (int j = i + 1; j <= numbers.Length - 1; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        curentLength++;
                        
                    }
                    else
                    {
                        break;
                    }
                }

                if (maxLength < curentLength)
                {
                    maxLength = curentLength;
                    bestIndex = numbers[i];
                }
            }

            for (int i = 0; i < maxLength; i++)
            {
                Console.Write($"{bestIndex} ");
            }
            Console.WriteLine();
        }
    }
}
