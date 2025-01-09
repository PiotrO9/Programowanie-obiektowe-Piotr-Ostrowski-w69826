using lab3.Klasy;

internal class Reviewer : Reader
{
    public Reviewer(string firstName, string lastName, int age) : base(firstName, lastName, age)
    {
    }

    public void Wypisz()
    {
        Console.WriteLine($"{FirstName} {LastName} jako recenzent przeczytał(a) następujące książki z oceną:");
        Random rand = new Random();
        foreach (var book in GetReadBooks())
        {
            int rating = rand.Next(1, 6);
            Console.WriteLine($"- {book.Title}: {rating}/5");
        }
    }

    public override void View()
    {
        base.View();
        Wypisz();
    }
}
