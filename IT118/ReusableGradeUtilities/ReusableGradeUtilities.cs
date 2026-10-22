
int[] examScores = { 77, 92, 14, 65, 95, 56, 82, 99 };
Console.WriteLine("Standard Scores");
ProcessAndPrint(examScores);

int[] boundaryScores = { 90, 90, 90, 90, 90 };
Console.WriteLine("Honor roll boundary (90)");
ProcessAndPrint(boundaryScores);

int[] invalidScores = { -42, 20, 0 };
Console.WriteLine("Errors");
ProcessAndPrint(invalidScores);

static bool TryGetLetterGrade(double average, out string letterGrade)
{
    if (average < 0 || average > 100)
    {
        letterGrade = "?";
        return false;
    }

    letterGrade = average switch
    {
        >= 90 => "A",
        >= 80 => "B",
        >= 70 => "C",
        >= 60 => "D",
        _ => "F"
    };
    
    return true;
}

static int CountAboveThreshold(int[] scores, int threshold)
{
    int count = 0;
    foreach (int score in scores)
    {
        if (score >= threshold)
        {
            count++;
        }
    }
    return count;
}

static double CalculateAverage(int[] scores)
{
    if (scores.Length == 0) return 0;
    
    int total = 0;
    foreach (int score in scores)
    {
        total += score;
    }
    
    return (double)total / scores.Length;
}

static void ProcessAndPrint(int[] scores)
{
    double average = CalculateAverage(scores);
    Console.WriteLine($"Class Average: {average}");

    bool isValid = TryGetLetterGrade(average, out string letterGrade);
    if (isValid)
    {
        Console.WriteLine($"Letter Grade: {letterGrade}");
    }
    else
    {
        Console.WriteLine($"Error: The average {average} is outside the valid 0-100 range.");
    }

    int honorRollCount = CountAboveThreshold(scores, 90);
    Console.WriteLine($"Honor Roll Count (Scores 90+): {honorRollCount}");
}