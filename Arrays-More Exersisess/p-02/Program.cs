using System;
using System.Collections.Generic;
using System.Linq;

namespace p_02
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> currList = new List<int>() {1};
            List<int> list = new List<int>() {1,1};

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (j==0)
                    {
                        Console.Write(string.Join(" ",currList));
                    }
                    else if (j==1)
                    {
                        Console.Write(string.Join(" ", list));
                    }
                    else
                    {

                    }
                }
                Console.WriteLine();
            }
        }
    }
}
