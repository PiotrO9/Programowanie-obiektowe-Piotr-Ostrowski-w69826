using lab2;

//Osoba osoba = new("Piotr", "Ostrowski", 21);

//BankAccount konto = new BankAccount("Jan Kowalski", 1000);
//konto.Wplata(500);
//konto.Wyplata(200);
//Console.WriteLine($"Saldo: {konto.Saldo}");

//Student student = new Student("Jan", "Kowalski");
//student.DodajOcene(4);
//student.DodajOcene(5);
//student.DodajOcene(3);
//Console.WriteLine($"Średnia ocen: {student.SredniaOcen}");

//Licz licz1 = new Licz(10);
//Licz licz2 = new Licz(20);

//licz1.Dodaj(5);
//licz1.WypiszStan();

//licz2.Odejmij(3);
//licz2.WypiszStan();

//licz1.Dodaj(10);
//licz1.WypiszStan();

//licz2.Odejmij(5);
//licz2.WypiszStan();


int[] dane = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Sumator sumator = new Sumator(dane);

Console.WriteLine($"Suma: {sumator.Suma()}");
Console.WriteLine($"Suma liczb podzielnych przez 2: {sumator.SumaPodziel2()}");
Console.WriteLine($"Liczba elementów: {sumator.IleElementów()}");

Console.WriteLine("Wszystkie elementy:");
sumator.WypiszWszystkieElementy();

Console.WriteLine("Elementy w zakresie 2 do 5:");
sumator.WypiszElementyWZakresie(2, 5);

Console.WriteLine("Elementy w zakresie -1 do 12 (z przekroczeniem zakresu):");
sumator.WypiszElementyWZakresie(-1, 12);