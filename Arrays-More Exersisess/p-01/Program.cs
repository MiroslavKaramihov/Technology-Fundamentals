using System;
using System.Collections.Generic;
using System.Linq;
namespace p_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<double> arr = new List<double> ();
                int counter = 0;

            while (true)
            {
                string input = Console.ReadLine();
                int length = input.Length ;
                double result = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i]=='a'|| input[i] == 'A'|| input[i] == 'e' || input[i] == 'E'|| input[i] == 'i' || input[i] == 'I' || input[i] == 'o' || input[i] == 'O' || input[i] == 'u' || input[i] == 'U')
                    {
                        result += input[i] * length;
                    }
                    else
                    {
                        result += input[i] / length;
                    }
                }

                arr.Add(result);

                counter++;
                if (counter==n)
                {
                    break;
                }
            }
            arr.Sort();

            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine();
        }
    }
}
