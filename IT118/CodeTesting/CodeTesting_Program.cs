int[] prices = { 12, 15, 11, 18, 20 };
for (int i = 0; i < prices.Length - 1; i++)
{
int change = prices[i + 1] - prices[i];
Console.WriteLine($"Day {i} to day {i + 1}: change of {change}");
}