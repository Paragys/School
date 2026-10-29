string[] words = { "apple", "pear", "apple", "fig", "pear", "apple" };

Dictionary<string,int> wordCounts = new Dictionary<string,int>();

foreach (string word in words)
{
    if (wordCounts.TryGetValue(word, out int currentCount))
    {
        wordCounts[word] = currentCount+ 1;   
    }
    else
    {
        wordCounts.Add(word, 1);
    }
}

foreach (KeyValuePair<string, int> entry in wordCounts)
{
    Console.WriteLine($"{entry.Key}: {entry.Value}");
}

if (wordCounts.TryGetValue("apple", out int appleCount))
{
    Console.WriteLine($"Existing word check: 'apple' count is {appleCount}");
}

if (wordCounts.TryGetValue("banana", out int bananaCount))
{
    Console.WriteLine($"Existing word check: 'banana' count is {bananaCount}");
}
else
{
    Console.WriteLine("Missing word check: 'banana' is not in the dictionary.");
}