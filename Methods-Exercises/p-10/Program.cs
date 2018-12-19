using System;
using System.Collections.Generic;
using System.Linq;

namespace p_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            var list = DivedByEitgh(num);
            var newlist = GetSomeOddDigits(list);


            newlist= newlist.Distinct().ToList();
            newlist.Remove(0);

            for (int i = 0; i < newlist.Count; i++)
            {
                Console.WriteLine(newlist[i]);
            }
           
        }

        private static List<int> GetSomeOddDigits(List<int> list)
        {
            for (int i = 0; i < list.Count;i++)
            {
                int currI = 0;
                int index = list[i];
                bool isTrue = false;

                while (true)
                {
                    currI = index % 10;
                    if (currI % 2 == 1)
                    {
                        isTrue = true;
                        break;
                    }
                    index /= 10;
                    if (index == 0)
                    {
                        break;
                    }

                }
                if (isTrue != true)
                {
                   list[i]=0;

                }
                
            }
            return list;
        }

        private static List<int> DivedByEitgh(int num)
        {
            List<int> list = new List<int>();

            for (int i = 10; i <= num; i++)
            {
                int sum = 0;
                int currI = 0;
                int index = i;

                while (true)
                {
                    currI = index % 10;
                    sum += currI;
                    index /= 10;

                    if (index == 0)
                    {
                        break;
                    }
                }
                if (sum % 8 == 0)
                {
                    list.Add(i);
                }
            }

            return list;
        }
    }
}
