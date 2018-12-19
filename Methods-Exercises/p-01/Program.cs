using System;

namespace p_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());


           int result =  GetSmalerNum(input, input1, input2);

            Console.WriteLine(result);

        }

        static int GetSmalerNum(int input, int input1, int input2)
        {
            int[] result = new int[3] { input, input1, input2 };



            if (result[0] < result[1] && result[2] > result[0])
            {
                return result[0];
            }
            else if (result[1] < result[0] && result[2] > result[1])
            {
                return result[1];
            }
            else
            {
                return result[2];
            }



        }
    }
}
