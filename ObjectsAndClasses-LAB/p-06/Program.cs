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




                

                if (IsStudentExisting(studentsList,firstName,lastName))
                {
                    Students student = GetStudents(studentsList, firstName, lastName);

                    student.FirstName = firstName;
                    student.LasttName = lastName;
                    student.Age = age;
                    student.Town = town;
                    
                }
                else
                {
                    Students student = new Students();

                    student.FirstName = firstName;
                    student.LasttName = lastName;
                    student.Age = age;
                    student.Town = town;
                    studentsList.Add(student);
                }

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

        private static Students GetStudents(List<Students> studentsList, string firstName, string lastName)
        {
            Students existingStudent = null;

            foreach (var students in studentsList)
            {
                if (students.FirstName==firstName&&students.LasttName==lastName)
                {
                    existingStudent = students;
                }
            }
            return existingStudent;
        }

        private static bool IsStudentExisting(List<Students> studentList, string firstName, string lastName)
        {
            foreach (var students in studentList)
            {
                if (students.FirstName==firstName&&students.LasttName==lastName)
                {
                    return true;
                }
            }
            return false;
        }
    }
    public class Students
    {



        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public string Age { get; set; }
        public string Town { get; set; }

    }
}

