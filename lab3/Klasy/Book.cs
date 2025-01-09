namespace lab3.Klasy
{
    class Book
    {
        protected string title;
        protected Person author;
        protected DateTime releaseDate;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public Person Author
        {
            get { return author; }
            set { author = value; }
        }

        public DateTime ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }

        public Book(string title, Person author, DateTime releaseDate)
        {
            Title = title;
            Author = author;
            ReleaseDate = releaseDate;
        }

        public virtual void View()
        {
            Console.WriteLine($"Tytuł: {Title}, Autor: {Author.FirstName} {Author.LastName}, Data wydania: {ReleaseDate.ToShortDateString()}");
        }
    }
}
