using System;
using System.Linq;

namespace p_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i <= number.Length - 1; i+=1)
            {
                for (int j = 1+i; j <= number.Length - 1; j++)
                {
                    if (number[i] + number[j] == sum)
                    {
                        Console.WriteLine($"{number[i]} {number[j]}");
                        break;
                    }
                        
                }
            }
           
        }
    }
}
