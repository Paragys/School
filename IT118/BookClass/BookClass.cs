Book basquiat = new Book("Basquait", "Benedikt Taschen", 511);
Book meditations = new Book("Meditations", "Marcus Aurelius", 191);

basquiat.Describe();
meditations.Describe();

public class Book
{
    public string title;
    public string author;
    public int pageCount;

    public Book(string title, string author, int pageCount)
    {
        this.title = title;
        this.author = author;
        this.pageCount = pageCount;
    }

    public void Describe()
    {
        Console.WriteLine($"{title} by {author} is {pageCount} pages long.");
    }
}