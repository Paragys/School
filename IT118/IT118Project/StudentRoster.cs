using System;
using System.Collections.Generic;

namespace IT118Project
{
    // EXAMPLE of a manager class that owns a collection (Chapter 6) and has
    // methods that loop and search (Chapters 4, 5, and 7).
    internal class StudentRoster
    {
        private List<Student> students = new List<Student>();

        // TODO (Part 1): Seed at least 3 records for your own scenario.
        public void LoadSeedData()
        {
            students.Add(new Student("Ava Martinez", 52));
            students.Add(new Student("Ben Carter", 118));
            students.Add(new Student("Chloe Nguyen", 12));
        }

        public void Add(Student student)
        {
            students.Add(student);
        }

        public void ListAll()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("The roster is empty.");
                return;
            }

            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + students[i]);
            }
        }

        public void PrintMatches(string text)
        {
            int found = 0;

            foreach (Student s in students)
            {
                if (s.Name.ToLower().Contains(text.ToLower()))
                {
                    Console.WriteLine(s);
                    found++;
                }
            }

            if (found == 0)
            {
                Console.WriteLine("No matches for \"" + text + "\".");
            }
        }
    }
}
