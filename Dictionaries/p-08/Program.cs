using System;
using System.Linq;
using System.Collections.Generic;


namespace p_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> listOfResults = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" -> ");

                string company = input[0];

                if (company=="End")
                {
                    break;
                }

                string id = input[1];

                if (!listOfResults.ContainsKey(company))
                {
                    listOfResults.Add(company, new List<string>());
                }

                bool isExist = true;

                foreach (var item in listOfResults)
                {
                    if (item.Key==company)
                    {
                        foreach (var kvp in item.Key)
                        {
                            if (!item.Value.Contains(id))
                            {
                                isExist = false;
                            }
                        }
                    }
                }

                if (isExist==false)
                {
                    listOfResults[company].Add(id);
                }
            }

            var result = listOfResults.OrderBy(x => x.Key);

            foreach (var item in result)
            {
                Console.WriteLine(item.Key);
                foreach (var value in item.Value)
                {
                    Console.WriteLine("-- " + value);
                }
            }
        }
    }
}
