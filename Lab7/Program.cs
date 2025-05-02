class Book
{
    private string title;
    private string author;

    public Book()  
    {
        title = "Unknown Title";
        author = "Unknown Author";
    }

    public Book(string newTitle)  
    {
        title = newTitle;
        author = "Unknown Author";
    }

    public Book(string newTitle, string newAuthor)  
    {
        title = newTitle;
        author = newAuthor;
    }

    public string GetTitle()
    {
        return title;
    }

    public void SetTitle(string newTitle)
    {
        title = newTitle;
    }

    public string GetAuthor()
    {
        return author;
    }

    public void SetAuthor(string newAuthor)
    {
        author = newAuthor;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        Console.WriteLine(book1.GetTitle());  

        book1.SetTitle("C# Fundamentals");
        Console.WriteLine(book1.GetTitle());  

        Book book2 = new Book("Advanced C#");
        Console.WriteLine(book2.GetTitle());  

        Book book3 = new Book("Mastering C#", "Cee Sharpe");
        Console.WriteLine(book3.GetTitle());  
        Console.WriteLine(book3.GetAuthor());  

        Book book4 = new Book();  
        book4.SetTitle("C# for Beginners");
        book4.SetAuthor("Homer Simpson");

        Console.WriteLine(book4.GetTitle());  
        Console.WriteLine(book4.GetAuthor());  
    }
}