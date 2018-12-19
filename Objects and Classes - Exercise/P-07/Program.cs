using System;
using System.Collections.Generic;
using System.Linq;

namespace P_07
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Members> membersList = new List<Members>();

            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                if (input[0]=="End")
                {
                    break;
                }

                string name = input[0];
                int id =int.Parse( input[1]);
                int age = int.Parse(input[2]);

                Members members = new Members();

                members.Name = name;
                members.ID = id;
                members.Age = age;

                membersList.Add(members);
            }

            var result = membersList.OrderBy(x => x.Age).ToList();

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} with ID: {item.ID} is {item.Age} years old.");
            }
        }
    }
    class Members
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int Age { get; set; }
    }
}
