BookRecord basquiat = new BookRecord("Basquait", "Benedikt Taschen");
BookRecord meditations = new BookRecord("Basquait", "Benedikt Taschen");

Console.WriteLine(basquiat == meditations); // Now prints True

BookRecord third = basquiat with { Title = "Meditations" };
Console.WriteLine(basquiat);
Console.WriteLine(third);

public record BookRecord(string Title, string Author);