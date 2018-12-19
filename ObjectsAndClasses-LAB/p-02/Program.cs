using System;
using System.Collections.Generic;


namespace p_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            var randomIndex = new Random();

            for (int i = 0; i < input.Length; i++)
            {
              var number=  randomIndex.Next(0,input.Length);

                string valueTempt = input[i];
                input[i] = input[number];
                input[number] = valueTempt;
            }

            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
    }
}
