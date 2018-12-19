using System;

namespace p_03
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            PrintBetwenerChar(start, end);
        }

        private static void PrintBetwenerChar(char start, char end)
        {
            char newStart = start;
            char newEnd = end;

            if (start>end)
            {
                newStart = end;
                newEnd = start;
            }

            for (char i = newStart; i < newEnd; i++)
            {
                if (i != newStart)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
