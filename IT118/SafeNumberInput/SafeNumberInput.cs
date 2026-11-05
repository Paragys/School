Console.Write("Please type a number:");
string? number = Console.ReadLine();

if (int.TryParse(number, out int parsedNumber))
{
    Console.WriteLine($"Doubled value: {parsedNumber * 2}");
}
else
{
    Console.WriteLine("That wasn't a valid number.");
}