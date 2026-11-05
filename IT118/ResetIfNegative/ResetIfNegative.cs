int negativeNumber = -5;
Console.WriteLine($"Before (negative test): {negativeNumber}");
ResetIfNegative(ref negativeNumber);
Console.WriteLine($"After (negative test): {negativeNumber}");

int positiveNumber = 10;
Console.WriteLine($"Before (positive test): {positiveNumber}");
ResetIfNegative(ref positiveNumber);
Console.WriteLine($"After (positive test): {positiveNumber}");

static void ResetIfNegative(ref int value)
{
    if (value < 0)
    {
        value = 0;
    }
}