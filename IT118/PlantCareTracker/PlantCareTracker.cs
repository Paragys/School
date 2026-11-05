Dictionary<string, int> plants = new Dictionary<string, int>();

plants.Add("Chompy", 1);
plants.Add("Giggles", 3);
plants.Add("Leafy", 2);
plants.Add("Mr. Cactus", 15);
plants.Add("Needy", 0);

foreach (KeyValuePair<string, int> entry in plants)
{
    Console.WriteLine($"Name of plant: {entry.Key}; days since last watered: {entry.Value}");
}

List<string> needsWater = new List<string>();

foreach (KeyValuePair<string, int> entry in plants)
{
    if (entry.Value >= 7)
    {
        needsWater.Add(entry.Key); // Changed colon to semicolon
    }
}

if (needsWater.Count == 0)
{
    Console.WriteLine("All plants are watered.");
}
else
{
    foreach (string plant in needsWater)
    {
        Console.WriteLine($"{plant} needs water!");
    }
}

if (plants.TryGetValue("Cactus", out int days))
{
    Console.WriteLine($"{days} days without water!");
}
else
{
    Console.WriteLine("Plant not found.");
}