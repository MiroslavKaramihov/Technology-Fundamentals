using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace p_07
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int strentgh = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];

                if (symbol == '>')
                {
                    strentgh += int.Parse(input[i + 1].ToString());
                    continue;
                }
                if (strentgh > 0)
                {
                    input = input.Remove(i, 1).ToString();
                    strentgh -- ;
                    i--;
                }
            }

            Console.WriteLine(input);
        }
    }
}
