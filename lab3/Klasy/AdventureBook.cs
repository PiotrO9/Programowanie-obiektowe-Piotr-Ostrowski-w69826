namespace lab3.Klasy
{
    class AdventureBook : Book
    {
        private string difficultyLevel;

        public string DifficultyLevel
        {
            get { return difficultyLevel; }
            set { difficultyLevel = value; }
        }

        public AdventureBook(string title, Person author, DateTime releaseDate, string difficultyLevel)
            : base(title, author, releaseDate)
        {
            DifficultyLevel = difficultyLevel;
        }

        public override void View()
        {
            base.View();
            Console.WriteLine($"Poziom trudności: {DifficultyLevel}");
        }
    }
}
