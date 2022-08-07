using System;
using System.Linq;
using System.Collections.Generic;

namespace _07.OrderByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Person> people = new List<Person>();

            while (input != "End")
            {
                string[] personInfo = input.Split(' ').ToArray();
                Person person = new Person(personInfo[0], personInfo[1], int.Parse(personInfo[2]));

                if (people.Any(x => x.ID == person.ID))
                {
                    int index = people.FindIndex(x => x.ID == person.ID);
                    people[index] = person;
                }
                else
                {
                    people.Add(person);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join("\n", people.OrderBy(x => x.Age)));
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string ID { get; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{this.Name} with ID: {this.ID} is {this.Age} years old.";
        }
        public Person(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
    }
}