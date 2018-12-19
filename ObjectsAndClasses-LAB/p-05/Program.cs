using System;
using System.Collections.Generic;
using System.Linq;

namespace p_05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> studentsList = new List<Students>();



            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                if (input[0] == "end")
                {
                    break;
                }

                string firstName = input[0];
                string lastName = input[1];
                string age = input[2];
                string town = input[3];

                Students students = new Students(firstName, lastName, age, town);

                studentsList.Add(students);
            }

            string existingTown = Console.ReadLine();

            foreach (var item in studentsList)
            {
                if (existingTown == item.Town)
                {
                    Console.WriteLine($"{item.FirstName} {item.LasttName} is {item.Age} years old.");
                }

            }

        }
    }
    public class Students
    {
        

        public Students(string firstName, string lastName, string age, string town)
        {
            FirstName = firstName;
            this.LasttName = lastName;
            this.Age = age;
            Town = town;
        }
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public string Age { get; set; }
        public string Town { get; set; }

    }
}
