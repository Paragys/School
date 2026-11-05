using System.Text;

string[] rawEntries = { "Brenden:99", "William:65", "Jimmy:fail", "Jeremy:78" };

int totalScore = 0;
int validCount = 0;

StringBuilder report = new StringBuilder();

foreach (string entry in rawEntries)

{
    string[] splitEntries = entry.Split(":");
    if (int.TryParse(splitEntries[1], out int score))
    {
        report.AppendLine($"{splitEntries[0]} scored {score}");
        totalScore += score;
        validCount++;
    }
    else
    {
        report.AppendLine($"{splitEntries[0]} has an invalid score and was skipped.");
    }

}

string finalReport = report.ToString();
Console.WriteLine(finalReport);

double average = (double)totalScore / validCount;
Console.WriteLine($"Average valid score: {average:F2}");