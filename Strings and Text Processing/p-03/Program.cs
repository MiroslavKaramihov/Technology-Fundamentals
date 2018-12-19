using System;
using System.Text;

namespace p_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string result = Console.ReadLine();

            StringBuilder stringBuilder = new StringBuilder();

            string res = " ";

            while (true)
            {
                int indexOfInput = result.IndexOf(input);

                if (indexOfInput == -1)
                {
                    break;
                }

                result = result.Remove(indexOfInput, input.Length).ToString();



            }

                stringBuilder.Append(result);
            Console.WriteLine(stringBuilder);
        }
    }
}
