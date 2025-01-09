using lab3.Klasy;

internal class DocumentaryBook : Book
{
    private bool realEvents;

    public bool RealEvents
    {
        get { return realEvents; }
        set { realEvents = value; }
    }

    public DocumentaryBook(string title, Person author, DateTime releaseDate, bool realEvents)
        : base(title, author, releaseDate)
    {
        RealEvents = realEvents;
    }

    public override void View()
    {
        base.View();
        Console.WriteLine($"Oparte na prawdziwych wydarzeniach: {(RealEvents ? "Tak" : "Nie")}");
    }
}
