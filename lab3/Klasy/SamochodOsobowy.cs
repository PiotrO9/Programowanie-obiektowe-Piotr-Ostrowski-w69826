namespace lab3.Klasy
{
    class SamochodOsobowy : Samochod
    {
        public double Waga { get; set; }
        public double PojemnoscSilnika { get; set; }
        public int IloscOsob { get; set; }

        public SamochodOsobowy() : base()
        {
            Console.WriteLine("Podaj wagę samochodu (w tonach):");
            Waga = double.Parse(Console.ReadLine());
            if (Waga < 2 || Waga > 4.5)
            {
                Console.WriteLine("Waga musi być w przedziale 2-4,5 t! Ustawiam na 2 t.");
                Waga = 2;
            }

            Console.WriteLine("Podaj pojemność silnika (w litrach):");
            PojemnoscSilnika = double.Parse(Console.ReadLine());
            if (PojemnoscSilnika < 0.8 || PojemnoscSilnika > 3.0)
            {
                Console.WriteLine("Pojemność silnika musi być w przedziale 0,8-3,0 l! Ustawiam na 0,8 l.");
                PojemnoscSilnika = 0.8;
            }

            Console.WriteLine("Podaj ilość osób w samochodzie:");
            IloscOsob = int.Parse(Console.ReadLine());
        }
        public SamochodOsobowy(string marka, string model, string nadwozie, string kolor, int rokProdukcji, double przebieg,
                                double waga, double pojemnoscSilnika, int iloscOsob)
            : base(marka, model, nadwozie, kolor, rokProdukcji, przebieg)
        {
            Waga = waga;
            PojemnoscSilnika = pojemnoscSilnika;
            IloscOsob = iloscOsob;
        }

        public override void WyswietlInformacje()
        {
            base.WyswietlInformacje();
            Console.WriteLine($"Waga: {Waga} t");
            Console.WriteLine($"Pojemność silnika: {PojemnoscSilnika} l");
            Console.WriteLine($"Ilość osób: {IloscOsob}");
        }
    }
}
