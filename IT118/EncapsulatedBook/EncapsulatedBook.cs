Book basquiat = new Book("Basquait", "Benedikt Taschen", 511);
Book meditations = new Book("Meditations", "Marcus Aurelius", 0);

basquiat.Describe();
meditations.Describe();

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    private int _pageCount;

    public int PageCount
    {
        get { return _pageCount; }
        set
        {
            if (value < 1)
                Console.WriteLine($"Rejected: {value} is not a valid page count.");
            else
                _pageCount = value;
        }
    }

    public Book(string title, string author, int pageCount)
{
    Title = title;
    Author = author;
    PageCount = pageCount;
}

    public void Describe()
    {
        Console.WriteLine($"{Title} by {Author} is {PageCount} pages long.");
    }
}