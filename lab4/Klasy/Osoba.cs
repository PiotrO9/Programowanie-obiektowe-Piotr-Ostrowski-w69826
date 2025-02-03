namespace lab4.Klasy
{

    public interface IOsoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        string ZwrocPelnaNazwe();
    }
    public interface IStudent : IOsoba
    {
        string Uczelnia { get; set; }
        string Kierunek { get; set; }
        int Rok { get; set; }
        int Semestr { get; set; }
        string WypiszPelnaNazweIUczelnie();
    }

    public class Student : IStudent
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Uczelnia { get; set; }
        public string Kierunek { get; set; }
        public int Rok { get; set; }
        public int Semestr { get; set; }

        public string ZwrocPelnaNazwe()
        {
            return $"{Imie} {Nazwisko}";
        }

        public virtual string WypiszPelnaNazweIUczelnie()
        {
            return $"{ZwrocPelnaNazwe()} – {Rok}ID-P {Semestr} {Uczelnia}";
        }
    }

    public class StudentWSIiZ : Student
    {
        public string Specjalizacja { get; set; }

        public override string WypiszPelnaNazweIUczelnie()
        {
            return $"{ZwrocPelnaNazwe()} – {Rok}ID-P {Semestr} {Uczelnia}, Specjalizacja: {Specjalizacja}";
        }
    }

    public class Osoba : IOsoba
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pesel { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public void SetFirstName(string firstName) => FirstName = firstName;
        public void SetLastName(string lastName) => LastName = lastName;
        public void SetPesel(string pesel) => Pesel = pesel;

        public string ZwrocPelnaNazwe() => $"{Imie} {Nazwisko}";

        public int GetAge()
        {
            if (Pesel.Length != 11) return 0;

            int year = int.Parse(Pesel.Substring(0, 2));
            int month = int.Parse(Pesel.Substring(2, 2));
            int day = int.Parse(Pesel.Substring(4, 2));

            int currentYear = DateTime.Now.Year;
            int currentMonth = DateTime.Now.Month;
            int currentDay = DateTime.Now.Day;

            if (year > currentYear % 100) year += 1900;
            else year += 2000;

            int age = currentYear - year;

            if (month > currentMonth || (month == currentMonth && day > currentDay))
            {
                age--;
            }

            return age;
        }

        public string GetGender()
        {
            if (Pesel.Length != 11) return "Niepoprawny PESEL";
            return int.Parse(Pesel.Substring(9, 1)) % 2 == 0 ? "Kobieta" : "Mężczyzna";
        }
        public virtual string GetEducationInfo() => "Brak informacji o edukacji";
        public string GetFullName() => $"{FirstName} {LastName}";
        public virtual bool CanGoAloneToHome() => false;
    }

    public static class OsobaExtensions
    {
        public static void WypiszOsoby(this List<IOsoba> listaOsob)
        {
            foreach (var osoba in listaOsob)
            {
                Console.WriteLine(osoba.ZwrocPelnaNazwe());
            }
        }
        public static void PosortujOsobyPoNazwisku(this List<IOsoba> listaOsob)
        {
            listaOsob.Sort((osoba1, osoba2) => osoba1.Nazwisko.CompareTo(osoba2.Nazwisko));
        }
    }

    public class Uczen : Osoba
    {
        public string School { get; set; }
        public bool MozeSamWracacDoDomu { get; set; }

        public void SetSchool(string school) => School = school;
        public void ChangeSchool(string newSchool) => School = newSchool;
        public void SetCanGoHomeAlone(bool canGoHomeAlone) => MozeSamWracacDoDomu = canGoHomeAlone;

        public override string GetEducationInfo() => $"Szkoła: {School}";

        public override bool CanGoAloneToHome()
        {
            return GetAge() >= 12 || MozeSamWracacDoDomu;
        }
    }

    public class Nauczyciel : Uczen
    {
        public string TytulNaukowy { get; set; }
        public List<Uczen> PodwladniUczniowie { get; set; } = new List<Uczen>();

        public void AddStudent(Uczen uczen)
        {
            PodwladniUczniowie.Add(uczen);
        }

        public void WhichStudentCanGoHomeAlone(DateTime dateToCheck)
        {
            Console.WriteLine($"Sprawdzanie uczniów, którzy mogą wrócić samodzielnie do domu na dzień {dateToCheck.ToShortDateString()}:");

            foreach (var uczen in PodwladniUczniowie)
            {
                if (uczen.CanGoAloneToHome())
                {
                    Console.WriteLine(uczen.GetFullName());
                }
            }
        }
    }
}
