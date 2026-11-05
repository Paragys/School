static void IncrementAttempts(ref int attempts)
{
attempts++;
}
int attempts = 0;
IncrementAttempts(ref attempts);
IncrementAttempts(ref attempts);
IncrementAttempts(ref attempts);
Console.WriteLine($"Total attempts: {attempts}");
