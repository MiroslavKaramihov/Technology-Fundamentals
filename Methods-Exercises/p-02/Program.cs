using System;

namespace p_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            int vowelsCount = GetVowelsCount(input);

            Console.WriteLine(vowelsCount);
        }

        private static int GetVowelsCount(string input)
        {
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
                {
                    count++;
                }
            }


            return count;

        }
    }
}
