﻿int total = 0;
for (int i = 1; i <= 5; i++)
{
total += i;
Console.WriteLine($"Adding day {i}, running total: {total}");
}
Console.WriteLine($"Final total after 5 days should be 15, got: {total}");
