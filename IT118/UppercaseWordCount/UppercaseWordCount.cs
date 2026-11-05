string sentence = "the quick brown fox jumps";

Console.WriteLine (sentence.ToUpper());

string[] words = sentence.Split(' ');
Console.WriteLine($"Split into {words.Length} words:");