namespace lab2
{
    internal class Student
    {
        private List<int> oceny;

        public Student(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            oceny = new List<int>();
        }

        public string Imie { get; private set; }
        public string Nazwisko { get; private set; }

        public double SredniaOcen
        {
            get
            {
                return oceny.Count > 0 ? oceny.Average() : 0;
            }
        }

        public void DodajOcene(int ocena)
        {
            if (ocena < 2 || ocena > 5)
                throw new ArgumentException("Ocena musi być w zakresie od 2 do 5.");
            oceny.Add(ocena);
        }
    }
}
