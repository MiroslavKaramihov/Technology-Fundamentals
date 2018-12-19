using System;
using System.Linq;

namespace p_09
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                bool isPalidom = IfInputIsPalidom(input);

                if (isPalidom==true)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }


        }

        private static bool IfInputIsPalidom(string input)
        {

            var reverseInput = input.Reverse().ToList();

            bool isPalidom = true;

            for (int i = 0; i < input.Length; i++)
            {

                if (reverseInput[i] != input[i])
                {
                    isPalidom = false;
                    
                }

            }
            return isPalidom;
        }
    }
}
