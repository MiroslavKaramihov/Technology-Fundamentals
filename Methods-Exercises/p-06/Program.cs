using System;

namespace p_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char result = ' ';
            string evenResult = " ";

            if (input.Length % 2 == 1)
            {
                result = GetMidCharOdd(input);
                Console.WriteLine(result);
            }
            else
            {
                evenResult = GetMidCharEven(input);
                Console.WriteLine(evenResult);
            }

        }

        private static string GetMidCharEven(string input)
        {
            int index = input.Length / 2;
            string result = " ";


            result = $"{input[index-1]}{input[index]}";

            return result;
        }

        private static char GetMidCharOdd(string input)
        {
            int index = input.Length / 2;
            char result = ' ';


            result = input[index];

            return result;

        }
    }
}
