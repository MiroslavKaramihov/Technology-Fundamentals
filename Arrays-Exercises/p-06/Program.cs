using System;
using System.Linq;

namespace p_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rithgSum = 0;
            int leftSum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                rithgSum += array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                rithgSum -= array[i];

                if (rithgSum == leftSum)
                {
                    Console.WriteLine(i);
                    break;
                }
                leftSum += array[i];
            }
            if (leftSum != rithgSum)
            {
                Console.WriteLine("no");
            }
        }
    }
}
