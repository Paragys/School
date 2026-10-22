int validScore = 76;
bool isValid = TryParseGrade(validScore, out char validGrade);

if (isValid)
{
    Console.WriteLine($"Nice! A score of {validScore} earns a grade of {validGrade}.");
}
else
{
    Console.WriteLine($"Error: {validScore} is outside the valid 0-100 range.");
}

int invalidScore = 99;
bool isInvalid = TryParseGrade(invalidScore, out char invalidGrade);

if (isInvalid)
{
    Console.WriteLine($"Well done! A score of {invalidScore} earns a grade of {invalidGrade}.");
}
else
{
    Console.WriteLine($"How did you get {invalidScore}? Because it falls outside 0-100, you get a '{invalidGrade}'.");
}

static bool TryParseGrade(int score, out char grade)
{
    if (score < 0 || score > 100)
    {
        grade = '?';
        return false;
    }

    grade = score switch
    {
        >= 90 => 'A',
        >= 80 => 'B',
        >= 70 => 'C',
        >= 60 => 'D',
        _ => 'F'
    };
    
    return true;
}