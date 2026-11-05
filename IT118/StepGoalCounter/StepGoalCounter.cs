int[] dailyStepCount = {3, 5, 11, 4, 10, 7, 8 };
int goalDays = 0;
int totalGoalSteps = 0;

foreach (int steps in dailyStepCount)
{
    if (steps >= 8)
    {
        goalDays++;
        totalGoalSteps += steps;
    }
}

Console.WriteLine($"Days reaching goal: {goalDays}");
Console.WriteLine($"Total steps on those days: {totalGoalSteps}.");