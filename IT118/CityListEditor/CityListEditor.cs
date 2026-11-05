List<string> cityNames = new List<string> { "Gladstone, OR", "Sacremento, CA", "New York, NY", "Milwaukee, WI" };

cityNames.Add("Washougal, WA");

cityNames.Remove("New York, NY");

foreach (string city in cityNames)
{
   Console.WriteLine(city);
}