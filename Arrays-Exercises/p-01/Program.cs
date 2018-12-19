using System;

namespace p_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                sum += input;
                arr[i] = input;
            }

            Console.WriteLine(string.Join(" ",arr));
            Console.WriteLine(sum);
        }
    }
}
