using System;

namespace IT118Project
{
    // EXAMPLE of encapsulation (Chapters 8 and 9): private fields, a constructor
    // that checks its input, and properties that control access.
    // Replace this with your own item class (Book, MenuItem, Animal, ...).
    internal class Student
    {
        private string name;
        private int credits;

        public Student(string name, int credits)
        {
            this.name = name;
            Credits = credits; // goes through the property so the check below runs
        }

        public string Name
        {
            get { return name; }
        }

        public int Credits
        {
            get { return credits; }
            set
            {
                if (value < 0)
                {
                    credits = 0;
                }
                else
                {
                    credits = value;
                }
            }
        }

        public string GetClassStanding()
        {
            if (credits >= 135) return "Senior";
            if (credits >= 90) return "Junior";
            if (credits >= 45) return "Sophomore";
            return "Freshman";
        }

        public override string ToString()
        {
            return Name + " - " + Credits + " credits (" + GetClassStanding() + ")";
        }
    }
}
