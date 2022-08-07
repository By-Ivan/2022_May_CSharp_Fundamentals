using System;
using System.Linq;
using System.Collections.Generic;

namespace _10.SoftUniCoursePlanning 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lesson = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();

            while (input != "course start")
            {
                string[] command = input.Split(':', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string operation = command[0];

                switch (operation)
                {
                    case "Add":
                        if (lesson.Contains(command[1]) == false)
                        {
                            lesson.Add(command[1]);
                        }
                        break;

                    case "Insert":
                        if (lesson.Contains(command[1]) == false)
                        {
                            lesson.Insert(int.Parse(command[2]), command[1]);
                        }
                        break;

                    case "Remove":
                        string rLesson = command[1];
                        string rExercise = rLesson + "-" + "Exercise";

                        if (lesson.Contains(rLesson))
                        {
                            lesson.Remove(rLesson);
                        }
                        if (lesson.Contains(rExercise))
                        {
                            lesson.Remove(rExercise);
                        }
                        break;

                    case "Swap":
                        if (lesson.Contains(command[1]) && lesson.Contains(command[2]))
                        {
                            string lesson1 = command[1];
                            string lesson2 = command[2];
                            string exercise1 = lesson1 + "-" + "Exercise";
                            string exercise2 = lesson2 + "-" + "Exercise";
                            int n1 = lesson.FindIndex(s => s == command[1]);
                            int n2 = lesson.FindIndex(s => s == command[2]);
                            int n3 = lesson.FindIndex(s => s == exercise1);
                            int n4 = lesson.FindIndex(s => s == exercise2);
                            lesson.RemoveAt(n1);
                            lesson.Insert(n1, lesson2);
                            lesson.RemoveAt(n2);
                            lesson.Insert(n2, lesson1);

                            if (lesson.Contains(exercise1))
                            {
                                lesson.RemoveAt(n3);
                                lesson.Insert(n1, lesson2);
                                lesson.RemoveAt(n2);
                                lesson.Insert(n2, lesson1);
                            }

                            if (lesson.Contains(exercise2))
                            {
                                lesson.RemoveAt(n1);
                                lesson.Insert(n1, lesson2);
                                lesson.RemoveAt(n2);
                                lesson.Insert(n2, lesson1);
                            }
                        }
                        break;

                    case "Exercise":
                        string exercise = command[1];
                        string finder = exercise + "-" + "Exercise";

                        if (lesson.Contains(finder) == false)
                        {
                            lesson.Insert(lesson.IndexOf(exercise) + 1, finder);
                        }
                        break;
                }
                input = Console.ReadLine();
            }
            for (int i = 0; i < lesson.Count; i++)
            {
                Console.WriteLine($"{i+1}.{lesson[i]}");
            }
        }
    }
}
