using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace p_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(':','\\','.');



          var result= input.TakeLast(2).ToList();


          


            Console.WriteLine($"File name: {result [0]}");
            Console.WriteLine($"File extension: {result[1]}");

        }
    }
}
