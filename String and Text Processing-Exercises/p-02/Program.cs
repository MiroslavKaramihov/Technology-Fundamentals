using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace p_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            var reult = SumCharSymbols(input[0], input[1]);

            Console.WriteLine(reult);
        }

        private static int SumCharSymbols(string v1, string v2)
        {
            int result = 0;
            int currntResult = 0;

            if (v1.Length == v2.Length)
            {
                for (int i = 0; i < v1.Length; i++)
                {
                    currntResult = v1[i] * v2[i];

                    result += currntResult;
                }

                
            }
            else if (v1.Length > v2.Length)
            {
                for (int i = 0; i < v1.Length; i++)
                {

                    if (v2.Length <= i)
                    {
                        result += v1[i];
                    }
                    else
                    {
                        currntResult = v1[i] * v2[i];
                        result += currntResult;
                    }
                }
            }
            else
            {
                for (int i = 0; i < v2.Length; i++)
                {

                    if (v1.Length <= i)
                    {
                        result += v2[i];
                    }
                    else
                    {
                        currntResult = v1[i] * v2[i];
                        result += currntResult;
                    }
                }
            }
            return result;
        }
    }
}
