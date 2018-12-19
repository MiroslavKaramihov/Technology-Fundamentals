using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace p_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] word = Console.ReadLine().Split(", ");
            string input = Console.ReadLine();

            foreach (var item in word)
            {
                string replecment = new string('*', item.Length);

                input = input.Replace(item, replecment);
            }

            Console.WriteLine(input);


        }
    }
}
