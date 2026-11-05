<<<<<<< HEAD
﻿string[] scoresText = { "72", "88", "ninety-one", "60" };
int total = 0;

foreach (string text in scoresText)
{
    if (int.TryParse(text, out int score))
    {
        total += score;
        Console.WriteLine($"Running total: {total}");
    }
    else
    {
        Console.WriteLine($"Skipping invalid score: {text}");
    }
}
Console.WriteLine($"Final total: {total}");
=======
﻿static void IncrementAttempts(ref int attempts)
{
attempts++;
}
int attempts = 0;
IncrementAttempts(ref attempts);
IncrementAttempts(ref attempts);
IncrementAttempts(ref attempts);
Console.WriteLine($"Total attempts: {attempts}");
>>>>>>> b466fd7b253bf75fc87d6c8f0dfa234fd67b44d1
