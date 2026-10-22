int[] examScores = { 89, 72, 72, 64, 48, 61, 55, 42 };

int sum = 0;
foreach (int score in examScores)
{
    sum += score;
}

double average = (double)sum / examScores.Length;
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Acverage: {average}");

for (int i = 0; i <examScores.Length; i++)
{
    Console.WriteLine($"Score {i + 1}: {examScores[i]}");
}

foreach (int score in examScores)
{
    if (score < 90)
    {
        continue;
    }
    Console.WriteLine($"Honor roll: {score}");
}

bool failingFound = false;
foreach (int score in examScores)
{
    if (score < 50)
    {
        Console.WriteLine($"First failing score found: {score}");
        failingFound = true;
        break;
    }
}

if (!failingFound)
{
    Console.WriteLine("No failing scores found.");
}