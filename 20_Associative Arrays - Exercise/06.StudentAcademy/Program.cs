using System;
using System.Linq;
using System.Collections.Generic;

namespace _06.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, new List<double>());
                    students[studentName].Add(studentGrade);
                }
                else
                {
                    students[studentName].Add(studentGrade);
                }
            }

            foreach (KeyValuePair<string, List<double>> keyValuePair in students)
            {
                double avgGrade = keyValuePair.Value.Sum() / keyValuePair.Value.Count;
                if (avgGrade < 4.50)
                {
                    students.Remove(keyValuePair.Key);
                }
                else
                {
                    Console.WriteLine($"{keyValuePair.Key} -> {avgGrade:f2}");
                }
            }
        }
    }
}

