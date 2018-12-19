using System;
using System.Collections.Generic;
using System.Linq;

namespace p_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());

            List<Students> listOfStudents = new List<Students>();

            for (int i = 0; i < countOfStudents; i++)
            {
                string[] input = Console.ReadLine().Split();

                var currStudent = new Students();

                currStudent.FirstName = input[0];
                currStudent.LastName = input[1];
                currStudent.Grade =double.Parse(input[2]);

                listOfStudents.Add(currStudent);
            }

            var result = listOfStudents.OrderByDescending(x => x.Grade);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}: {item.Grade:f2}");
            }
        }
    }
    public class Students
    {
        public string FirstName { get;set; }
        public string LastName { get;set; }
        public double Grade { get; set; }
    }
}
