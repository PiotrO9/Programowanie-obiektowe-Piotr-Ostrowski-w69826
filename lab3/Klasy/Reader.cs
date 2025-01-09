using lab3.Klasy;

class Reader : Person
{
    private List<Book> readBooks;

    public Reader(string firstName, string lastName, int age) : base(firstName, lastName, age)
    {
        readBooks = new List<Book>();
    }

    public void AddBook(Book book)
    {
        readBooks.Add(book);
    }

    public List<Book> GetReadBooks()
    {
        return readBooks;
    }

    public void ViewBook()
    {
        Console.WriteLine($"{FirstName} {LastName} przeczytał(a) następujące książki:");
        if (readBooks.Count == 0)
        {
            Console.WriteLine("Brak przeczytanych książek.");
        }
        else
        {
            foreach (var book in readBooks)
            {
                book.View();
            }
        }
    }

    public override void View()
    {
        base.View();
        ViewBook();
    }
}
