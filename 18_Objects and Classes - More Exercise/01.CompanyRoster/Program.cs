using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.CompanyRoster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                string[] employeeInfo = Console.ReadLine().Split().ToArray();
                employees.Add(new Employee(employeeInfo[0], decimal.Parse(employeeInfo[1]), employeeInfo[2]));
            }

            List<string> departments = employees.Select(x => x.Department).Distinct().ToList();

            decimal maxSalary = 0;
            string highestPaidDepartment = string.Empty;

            foreach (string department in departments)
            {
                decimal salary = employees.Where(x => x.Department == department).Average(x => x.Salary);

                if (maxSalary < salary)
                {
                    maxSalary = salary;
                    highestPaidDepartment = department;
                }
            }

            Console.WriteLine($"Highest Average Salary: {highestPaidDepartment}");
            Console.WriteLine(string.Join("\n", employees.Where(x => x.Department == highestPaidDepartment).OrderByDescending(x => x.Salary)));
        }
    }

    class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
        public override string ToString()
        {
            return $"{this.Name} {this.Salary:f2}";
        }
        public Employee(string name, decimal salary, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Department = department;
        }
    }
}