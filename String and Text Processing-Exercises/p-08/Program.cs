using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace p_08
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries ).ToList();
            var resultList = new List<decimal>();


            for (int i = 0; i < list.Count; i++)
            {
                decimal result = 0;
                string sb = "";

                var item = list[i];

                var firstLatter = item.First();
                var lastLatter = item.Last();

                var isFirstUpper = char.IsUpper(firstLatter);
                var isLastUpper = char.IsUpper(lastLatter);

                for (int j = 0; j < item.Length; j++)
                {
                    if (char.IsDigit(item[j]))
                    {
                        sb += item[j];
                    }
                }

                decimal number = decimal.Parse(sb);

                if (isFirstUpper)
                {
                    decimal letterPosition = firstLatter - 64;

                    result = number/ letterPosition;

                }
                else
                {
                    decimal letterPosition = firstLatter - 96;
                    result = number * letterPosition;
                }
                if (isLastUpper)
                {
                    decimal letterPosition = lastLatter - 64;
                    
                    result -= letterPosition;
                }
                else
                {
                    decimal letterPosition = lastLatter - 96;
                    result += letterPosition;
                }

                resultList.Add(result);
            }

            decimal sum = 0;

            for (int i = 0; i < resultList.Count; i++)
            {
                sum += resultList[i];
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
