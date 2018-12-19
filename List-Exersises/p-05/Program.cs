using System;
using System.Linq;
using System.Collections.Generic;

namespace p_05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] manipulateValue = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bombNum = manipulateValue[0];
            int bombPower = manipulateValue[1];

            int sequensBombIndex = 0;

            for (int i = 0; i < input.Count; i++)
            {
                int startIndex = i - bombPower;
                int count =  (bombPower * 2)+1;
                if (input[i] == bombNum)
                {
                    if (startIndex < 0)
                    {
                        startIndex = Math.Abs(startIndex);
                        count = count - startIndex;
                        startIndex = 0;
                    }
                    else if(startIndex+count>input.Count-1)
                    {
                        input.Reverse();
                        startIndex = Math.Abs(startIndex);
                        count = count - startIndex;
                        startIndex = 0;
                    }
                    input.RemoveRange(startIndex, count);

                    i = -1;
                }

            }



            var rusult = input.Sum();

            Console.WriteLine(rusult);
        }
    }
}
