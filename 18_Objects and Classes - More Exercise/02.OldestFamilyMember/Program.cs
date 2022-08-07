using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.OldestFamilyMember
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();

                Person person = new Person(input[0], int.Parse(input[1]));

                family.AddMember(person);
            }

            family.GetOldestMember();
        }
    }

    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString() => $"{this.Name} {this.Age}";
    }

    class Family
    {
        public Family()
        {
            Members = new List<Person>();
        }
        public List<Person> Members { get; set; }

        public void AddMember(Person member)
        {
            Members.Add(member);
        }

        public void GetOldestMember()
        {
            int age = Members.Select(x => x.Age).Max();
            Console.WriteLine($"{Members.First(x => x.Age == age)}");
        }
    }
}
