using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Klasy
{
    enum Kolor
    {
        Czerwony,
        Niebieski,
        Zielony,
        Zolty,
        Fioletowy
    }
    class GraKolory
    {
        private List<Kolor> dostepneKolory = new List<Kolor> { Kolor.Czerwony, Kolor.Niebieski, Kolor.Zielony, Kolor.Zolty, Kolor.Fioletowy };
        private Kolor wylosowanyKolor;
        private Random random = new Random();
        public GraKolory()
        {
            wylosowanyKolor = dostepneKolory[random.Next(dostepneKolory.Count)];
        }
        public void RozpocznijGre()
        {
            Console.WriteLine("Zgadnij kolor: Czerwony, Niebieski, Zielony, Zolty, Fioletowy");
            bool trafiono = false;
            while (!trafiono)
            {
                Console.Write("Podaj kolor: ");
                string input = Console.ReadLine();

                try
                {
                    Kolor wybranyKolor = (Kolor)Enum.Parse(typeof(Kolor), input, true);
                    if (!dostepneKolory.Contains(wybranyKolor))
                    {
                        throw new ArgumentException("Podano kolor spoza dostępnej listy.");
                    }

                    if (wybranyKolor == wylosowanyKolor)
                    {
                        Console.WriteLine("Gratulacje! Zgadłeś poprawny kolor!");
                        trafiono = true;
                    }
                    else
                    {
                        Console.WriteLine("Nieprawidłowy kolor, spróbuj ponownie.");
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Nieprawidłowy kolor! Podaj jeden z dostępnych: Czerwony, Niebieski, Zielony, Zolty, Fioletowy");
                }
                catch (Exception)
                {
                    Console.WriteLine("Wystąpił nieoczekiwany błąd. Spróbuj ponownie.");
                }
            }
        }
    }
}
