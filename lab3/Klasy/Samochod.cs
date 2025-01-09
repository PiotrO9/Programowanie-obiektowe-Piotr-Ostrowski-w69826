namespace lab3.Klasy
{
    class Samochod
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Nadwozie { get; set; }
        public string Kolor { get; set; }
        public int RokProdukcji { get; set; }
        public double Przebieg { get; set; }

        public Samochod()
        {
            Console.WriteLine("Podaj markę samochodu:");
            Marka = Console.ReadLine();

            Console.WriteLine("Podaj model samochodu:");
            Model = Console.ReadLine();

            Console.WriteLine("Podaj rodzaj nadwozia:");
            Nadwozie = Console.ReadLine();

            Console.WriteLine("Podaj kolor samochodu:");
            Kolor = Console.ReadLine();

            Console.WriteLine("Podaj rok produkcji:");
            RokProdukcji = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj przebieg samochodu:");
            Przebieg = double.Parse(Console.ReadLine());
            if (Przebieg < 0)
            {
                Console.WriteLine("Przebieg nie może być ujemny! Ustawiam na 0.");
                Przebieg = 0;
            }
        }

        public Samochod(string marka, string model, string nadwozie, string kolor, int rokProdukcji, double przebieg)
        {
            Marka = marka;
            Model = model;
            Nadwozie = nadwozie;
            Kolor = kolor;
            RokProdukcji = rokProdukcji;
            Przebieg = przebieg < 0 ? 0 : przebieg;
        }

        public virtual void WyswietlInformacje()
        {
            Console.WriteLine($"Marka: {Marka}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Nadwozie: {Nadwozie}");
            Console.WriteLine($"Kolor: {Kolor}");
            Console.WriteLine($"Rok produkcji: {RokProdukcji}");
            Console.WriteLine($"Przebieg: {Przebieg} km");
        }
    }
}
