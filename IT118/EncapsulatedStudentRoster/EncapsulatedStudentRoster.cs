List<Student> roster = new List<Student>
{
    new Student("Priya", 99),
    new Student("Marcus", 62),
    new Student("Devon", 85),
    new Student("David", 101)
};



foreach (Student s in roster)
{
    Console.WriteLine($"{s.Name}: {s.Score}");
}

Console.WriteLine("--- Bonus Tests (Marcus) ---");
roster[1].ApplyBonus(10);
Console.WriteLine($"{roster[1].Name}'s score after first bonus: {roster[1].Score}");

roster[1].ApplyBonus(30);
Console.WriteLine($"{roster[1].Name}'s score after second bonus: {roster[1].Score}");

public class Student
{
    public string Name { get; set; }
    private int _score = 0; // Assigned a value of 0 as a starting point.

    public int Score
    {
        get { return _score; }
        set
        {
           if (value < 0 || value > 100)
                Console.WriteLine($"Rejected: {value} is not a valid score.");
            else
                _score = value;
        }
    }
public Student(string name, int score)
{
    Name = name;
    Score = score;
}
public void ApplyBonus(int amount)
    {
        Score = Score + amount;
    }
}