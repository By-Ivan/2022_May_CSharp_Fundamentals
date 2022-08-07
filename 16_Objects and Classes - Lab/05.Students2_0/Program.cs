using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Students2_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] studentInfo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                Student student = new Student(studentInfo[0], studentInfo[1], int.Parse(studentInfo[2]), studentInfo[3]);
                bool isFound = false;

                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].FullName == student.FullName)
                    {
                        students.RemoveAt(i);
                        students.Insert(i, student);
                        isFound = true;
                    }
                }
                if (!isFound)
                {
                    students.Add(student);
                }

                input = Console.ReadLine();
            }

            string cityName = Console.ReadLine();

            foreach (Student s in students)
            {
                if (s.HomeTown == cityName)
                {
                    Console.WriteLine($"{s.FirstName} {s.LastName} is {s.Age} years old.");
                }
            }
        }
    }

    class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
