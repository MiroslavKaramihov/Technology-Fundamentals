using System;
using System.Linq;
using System.Collections.Generic;

namespace p_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> listResult = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string user = Console.ReadLine();
                double currGrade = double.Parse(Console.ReadLine());

                if (!listResult.ContainsKey(user))
                {

                    listResult.Add(user, new List<double>());
                }
                listResult[user].Add(currGrade);
            }

            Dictionary<string, double> result = new Dictionary<string, double>();

            foreach (var item in listResult)
            {
                double avrgGrade = 0;
                int count = 0;
                double sum = 0;

                foreach (var kvp in item.Value)
                {
                    count++;
                    sum += kvp;
                }

                avrgGrade = sum / count;

                result.Add(item.Key, avrgGrade);
            }

            var fina = result.OrderByDescending(x => x.Value);

            foreach (var item in fina)
            {
                if (item.Value >= 4.50)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value:f2}");
                }
            }
        }
    }
}
