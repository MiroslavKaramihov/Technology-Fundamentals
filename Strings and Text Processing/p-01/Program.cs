using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace p_01
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                StringBuilder sb = new StringBuilder();

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    sb.Append(input[i]);
                }
                    Console.WriteLine($"{input} = {sb}");

            }

        }
    }
}
