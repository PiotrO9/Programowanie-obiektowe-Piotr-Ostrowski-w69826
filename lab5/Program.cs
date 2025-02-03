using lab5;

//Zadanie 1

//static double WykonajOperacje(double a, double b, Operacja operacja)
//{
//    return operacja switch
//    {
//        Operacja.Dodawanie => a + b,
//        Operacja.Odejmowanie => a - b,
//        Operacja.Mnozenie => a * b,
//        Operacja.Dzielenie => b != 0 ? a / b : throw new DivideByZeroException(),
//        _ => throw new ArgumentException("Nieznana operacja")
//    };
//}

//List<double> historiaWynikow = new List<double>();

//while (true)
//{
//    try
//    {
//        Console.WriteLine("Podaj pierwszą liczbę:");
//        double liczba1 = Convert.ToDouble(Console.ReadLine());

//        Console.WriteLine("Podaj drugą liczbę:");
//        double liczba2 = Convert.ToDouble(Console.ReadLine());

//        Console.WriteLine("Wybierz operację: Dodawanie, Odejmowanie, Mnozenie, Dzielenie");
//        if (!Enum.TryParse(Console.ReadLine(), out Operacja operacja))
//        {
//            Console.WriteLine("Niepoprawna operacja. Spróbuj ponownie.");
//            continue;
//        }

//        double wynik = WykonajOperacje(liczba1, liczba2, operacja);
//        historiaWynikow.Add(wynik);
//        Console.WriteLine($"Wynik: {wynik}");

//        Console.WriteLine("Historia wyników:");
//        foreach (var wynikPoprzedni in historiaWynikow)
//        {
//            Console.WriteLine(wynikPoprzedni);
//        }
//    }
//    catch (FormatException)
//    {
//        Console.WriteLine("Błąd: Wprowadzona wartość nie jest liczbą. Spróbuj ponownie.");
//    }
//    catch (DivideByZeroException)
//    {
//        Console.WriteLine("Błąd: Nie można dzielić przez zero.");
//    }

//    Console.WriteLine("Czy chcesz kontynuować? (T/N)");
//    if (Console.ReadLine()?.ToUpper() != "T")
//        break;
//}

//Zadanie 2 


