string[] scoresText = { "72", "88", "ninety-one", "60" };
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