using System;

namespace IT118Project
{
    // STARTER FILE. This program already runs. It uses a made-up "Student roster"
    // as a worked example. Replace the example with your own scenario:
    //   A. Campus Library Desk   B. Food Truck Ordering   C. Pet Adoption Shelter
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO (Part 1): Rename StudentRoster to your own manager class
            // (for example Library, FoodTruck, or Shelter).
            StudentRoster roster = new StudentRoster();
            roster.LoadSeedData();

            bool running = true;
            while (running)
            {
                ShowMenu();
                int choice = InputHelper.ReadInt("Choose an option: ", 0, 4);

                switch (choice)
                {
                    case 1:
                        roster.ListAll();
                        break;
                    case 2:
                        AddStudent(roster);
                        break;
                    case 3:
                        SearchStudents(roster);
                        break;
                    case 4:
                        // TODO (Part 1): Add a fourth action for your scenario
                        // (for example check out an item, or record an adoption).
                        Console.WriteLine("Not built yet.");
                        break;
                    case 0:
                        running = false;
                        break;
                }

                Console.WriteLine();
            }

            Console.WriteLine("Goodbye.");
        }

        static void ShowMenu()
        {
            Console.WriteLine("=== Student Roster (EXAMPLE) ===");
            Console.WriteLine("1. List all");
            Console.WriteLine("2. Add");
            Console.WriteLine("3. Search by name");
            Console.WriteLine("4. (your action here)");
            Console.WriteLine("0. Exit");
        }

        static void AddStudent(StudentRoster roster)
        {
            string name = InputHelper.ReadText("Name: ");
            int credits = InputHelper.ReadInt("Credits (0 to 200): ", 0, 200);
            roster.Add(new Student(name, credits));
            Console.WriteLine("Added " + name + ".");
        }

        static void SearchStudents(StudentRoster roster)
        {
            string text = InputHelper.ReadText("Search for: ");
            roster.PrintMatches(text);
        }
    }
}
