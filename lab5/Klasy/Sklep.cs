using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Klasy
{
    enum StatusZamowienia
    {
        Oczekujace,
        Przyjete,
        Zrealizowane,
        Anulowane
    }
    class Sklep
    {
        private Dictionary<int, (StatusZamowienia status, List<string> produkty)> zamowienia = new();

        public void DodajZamowienie(int numerZamowienia, List<string> produkty)
        {
            if (zamowienia.ContainsKey(numerZamowienia))
            {
                Console.WriteLine("Zamówienie o tym numerze już istnieje.");
                return;
            }
            zamowienia[numerZamowienia] = (StatusZamowienia.Oczekujace, produkty);
        }

        public void ZmienStatusZamowienia(int numerZamowienia, StatusZamowienia nowyStatus)
        {
            if (!zamowienia.ContainsKey(numerZamowienia))
            {
                throw new KeyNotFoundException("Nie znaleziono zamówienia o podanym numerze.");
            }

            var (aktualnyStatus, produkty) = zamowienia[numerZamowienia];

            if (aktualnyStatus == nowyStatus)
            {
                throw new ArgumentException("Nowy status jest taki sam jak obecny.");
            }

            zamowienia[numerZamowienia] = (nowyStatus, produkty);
        }

        public void WyswietlZamowienia()
        {
            if (zamowienia.Count == 0)
            {
                Console.WriteLine("Brak zamówień.");
                return;
            }

            foreach (var zamowienie in zamowienia)
            {
                Console.WriteLine($"Zamówienie #{zamowienie.Key}: Status - {zamowienie.Value.status}");
                Console.WriteLine("Produkty:");
                foreach (var produkt in zamowienie.Value.produkty)
                {
                    Console.WriteLine($"- {produkt}");
                }
                Console.WriteLine();
            }
        }
    }
}
