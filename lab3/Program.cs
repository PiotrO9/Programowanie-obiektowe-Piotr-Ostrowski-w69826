using lab3.Klasy;
using System.Reflection.PortableExecutable;
using System;

//Zadanie 1

Person author1 = new Person("Jan", "Kowalski", 45);
Person author2 = new Person("Anna", "Nowak", 34);

AdventureBook adventureBook1 = new AdventureBook("Wielka Przygoda", author1, new DateTime(2015, 5, 20), "Średni");
DocumentaryBook documentaryBook1 = new DocumentaryBook("Historie z Życia", author2, new DateTime(2020, 7, 10), true);
AdventureBook adventureBook2 = new AdventureBook("Tajemnica Gór", author1, new DateTime(2022, 1, 15), "Trudny");
DocumentaryBook documentaryBook2 = new DocumentaryBook("Dzieje Wojny", author2, new DateTime(2021, 3, 25), false);

Reader reader1 = new Reader("Marek", "Nowak", 30);
Reader reader2 = new Reader("Kasia", "Zawisza", 25);
Reviewer reviewer1 = new Reviewer("Piotr", "Białek", 40);
Reviewer reviewer2 = new Reviewer("Magda", "Kwiatkowska", 35);

reader1.AddBook(adventureBook1);
reader1.AddBook(documentaryBook1);

reader2.AddBook(documentaryBook1);
reader2.AddBook(adventureBook2);

reviewer1.AddBook(adventureBook1);
reviewer1.AddBook(documentaryBook2);

reviewer2.AddBook(documentaryBook2);
reviewer2.AddBook(adventureBook2);

List<Person> people = new List<Person>();
people.Add(reader1);
people.Add(reader2);
people.Add(reviewer1);
people.Add(reviewer2);

foreach (var person in people)
{
    person.View();
    Console.WriteLine();
}

//Zadanie 2
Console.WriteLine("Tworzenie obiektu klasy Samochod:");
Samochod samochod1 = new Samochod();

Console.WriteLine("\nTworzenie obiektu klasy SamochodOsobowy:");
SamochodOsobowy samochodOsobowy = new SamochodOsobowy();

Console.WriteLine("\nTworzenie obiektu klasy Samochod z parametrami:");
Samochod samochod2 = new Samochod("BMW", "X5", "SUV", "Czarny", 2020, 35000);

Console.WriteLine("\nInformacje o pierwszym samochodzie:");
samochod1.WyswietlInformacje();

Console.WriteLine("\nInformacje o samochodzie osobowym:");
samochodOsobowy.WyswietlInformacje();

Console.WriteLine("\nInformacje o drugim samochodzie:");
samochod2.WyswietlInformacje();