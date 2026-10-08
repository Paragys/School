object input = 3; // change this line for each trial
if (input is int n && n > 5)
Console.WriteLine($"Big number: {n}");
else if (input is int num && num <= 5)
Console.WriteLine($"Small number: {num}");
else if (input is string s)
Console.WriteLine($"Text of length {s.Length}");
else
Console.WriteLine("Something else"); 