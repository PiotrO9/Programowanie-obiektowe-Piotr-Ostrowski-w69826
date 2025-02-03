using lab4.Klasy;
using static lab4.Klasy.Shape;

//Zadanie 1
//List<Shape> shapes = new List<Shape>();

//shapes.Add(new Rectangle());
//shapes.Add(new Triangle());
//shapes.Add(new Circle());

//foreach (var shape in shapes)
//{
//    shape.Draw();
//}

//Zadanie 2
//Uczen uczen1 = new Uczen();
//uczen1.SetFirstName("Jan");
//uczen1.SetLastName("Kowalski");
//uczen1.SetPesel("12345678901");
//uczen1.SetSchool("Szkoła Podstawowa nr 1");
//uczen1.SetCanGoHomeAlone(true);

//Uczen uczen2 = new Uczen();
//uczen2.SetFirstName("Anna");
//uczen2.SetLastName("Nowak");
//uczen2.SetPesel("98765432109");
//uczen2.SetSchool("Szkoła Podstawowa nr 2");
//uczen2.SetCanGoHomeAlone(false);

//Nauczyciel nauczyciel = new Nauczyciel();
//nauczyciel.SetFirstName("Katarzyna");
//nauczyciel.SetLastName("Wójcik");
//nauczyciel.SetPesel("12378965401");
//nauczyciel.TytulNaukowy = "Mgr";
//nauczyciel.SetSchool("Szkoła Podstawowa nr 1");

//nauczyciel.AddStudent(uczen1);
//nauczyciel.AddStudent(uczen2);

//nauczyciel.WhichStudentCanGoHomeAlone(DateTime.Now);

//Zadania 3
//List<IOsoba> osoby = new List<IOsoba>
//{
//    new Osoba { Imie = "Piotr", Nazwisko = "Wiśniewski" },
//    new Osoba { Imie = "Jan", Nazwisko = "Kowalski" },
//    new Osoba { Imie = "Anna", Nazwisko = "Nowak" }
//};
//osoby.PosortujOsobyPoNazwisku();
//osoby.WypiszOsoby();

//IStudent student = new Student
//{
//    Imie = "Jan",
//    Nazwisko = "Kowalski",
//    Uczelnia = "WSIiZ",
//    Kierunek = "Informatyka",
//    Rok = 4,
//    Semestr = 2
//};

//Console.WriteLine(student.WypiszPelnaNazweIUczelnie());

List<IStudent> studenci = new List<IStudent>
{
    new StudentWSIiZ { Imie = "Jan", Nazwisko = "Kowalski", Uczelnia = "WSIiZ", Kierunek = "Informatyka", Rok = 4, Semestr = 2, Specjalizacja = "Programowanie" },
    new StudentWSIiZ { Imie = "Anna", Nazwisko = "Nowak", Uczelnia = "WSIiZ", Kierunek = "Informatyka", Rok = 3, Semestr = 1, Specjalizacja = "Bazy Danych" },
    new StudentWSIiZ { Imie = "Piotr", Nazwisko = "Wiśniewski", Uczelnia = "WSIiZ", Kierunek = "Informatyka", Rok = 2, Semestr = 3, Specjalizacja = "Sieci Komputerowe" }
};

foreach (var student in studenci)
{
    Console.WriteLine(student.WypiszPelnaNazweIUczelnie());
}