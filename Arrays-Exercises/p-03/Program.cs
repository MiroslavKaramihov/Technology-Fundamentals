using System;
using System.Linq;

namespace p_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] arrResult1 = new string[n];
            string[] arrResult2 = new string[n];

            int count = 0;

            int result1Count = 0;
            int result2Count = 0;

            for (int i = 0; i < n/2; i++)
            {

            
                string[] input1 = Console.ReadLine().Split().ToArray();
                string[] input2 = Console.ReadLine().Split().ToArray();

                arrResult1[result1Count] = input1[0];
                arrResult2[result2Count] = input1[1];
                result1Count++;
                result2Count++;

                
                arrResult1[result1Count] = input2[1];
                arrResult2[result2Count] = input2[0];

                result1Count++;
                result2Count++;
                
            }

            Console.WriteLine(string.Join(" ", arrResult1));
            Console.WriteLine(string.Join(" ", arrResult2));
        }
    }
}
