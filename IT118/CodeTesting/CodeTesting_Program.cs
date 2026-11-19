List<Student> roster = new List<Student>
{
new Student("Priya", 91),
new Student("Marcus", 78)
};
Student found = FindStudent(roster, "Devon");
if (found == null)
    {
        Console.WriteLine("No one with that name was found.");
    }
    else
    {
     found.Describe();
    }
Student FindStudent(List<Student> students, string name)
{
foreach (Student s in students)
{
if (s.name == name)
{
return s;
}
}
return null;
}

public class Student
{
public string name;
public int score;
public Student(string name, int score)
{
this.name = name;
this.score = score;
}
public void Describe()
{
Console.WriteLine($"{name}: {score}");
}
}