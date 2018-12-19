using System;

namespace p_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());

            int sum = FirstTwoDigitSum(input, input1);
            int resultSubtract= Subtract(sum, input2);

            Console.WriteLine(resultSubtract);
        }

        private static int Subtract(int sum, int input2)
        {
            int result = sum - input2;

            return result;
        }

        private static int FirstTwoDigitSum(int input, int input1)
        {
            int sum = input + input1;

            return sum;
        }
    }
}
