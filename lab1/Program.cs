void zadanie1()
{
    Console.WriteLine("Podaj a: ");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Podaj b: ");
    double b = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Podaj c: ");
    double c = Convert.ToDouble(Console.ReadLine());

    double delta = b * b - 4 * a * c;
    Console.Write("Delta wynosi: ");
    Console.WriteLine(delta);

    if (delta > 0)
    {
        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
        Console.WriteLine("Równanie ma dwa pierwiastki: x1 = " + x1 + ", x2 = " + x2);
    }
    else if (delta == 0)
    {
        double x0 = -b / (2 * a);
        Console.WriteLine("Równanie ma jeden pierwiastek podwójny: x0 = " + x0);
    }
    else
    {
        Console.WriteLine("Równanie nie ma rzeczywistych pierwiastków.");
    }
}

void zadanie2()
{
    while (true)
    {
        Console.WriteLine("\nWybierz operację:");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Różnica");
        Console.WriteLine("3. Iloczyn");
        Console.WriteLine("4. Iloraz");
        Console.WriteLine("5. Potęga");
        Console.WriteLine("6. Pierwiastek kwadratowy");
        Console.WriteLine("7. Sinus");
        Console.WriteLine("8. Cosinus");
        Console.WriteLine("9. Tangens");
        Console.WriteLine("10. Wyjście");

        int choice = int.Parse(Console.ReadLine());

        if (choice == 10)
            break;

        double a = 0, b = 0;
        if (choice >= 1 && choice <= 5)
        {
            Console.WriteLine("Podaj pierwszą liczbę: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            b = Convert.ToDouble(Console.ReadLine());
        }
        else if (choice == 6)
        {
            Console.WriteLine("Podaj liczbę do obliczenia pierwiastka: ");
            a = Convert.ToDouble(Console.ReadLine());
        }
        else if (choice >= 7 && choice <= 9)
        {
            Console.WriteLine("Podaj kąt (w radianach): ");
            a = Convert.ToDouble(Console.ReadLine());
        }

        Console.Clear();

        switch (choice)
        {
            case 1:
                Console.WriteLine("Suma: " + (a + b));
                break;
            case 2:
                Console.WriteLine("Różnica: " + (a - b));
                break;
            case 3:
                Console.WriteLine("Iloczyn: " + (a * b));
                break;
            case 4:
                if (b != 0)
                    Console.WriteLine("Iloraz: " + (a / b));
                else
                    Console.WriteLine("Błąd: dzielenie przez zero");
                break;
            case 5:
                Console.WriteLine("Potęga: " + Math.Pow(a, b));
                break;
            case 6:
                if (a >= 0)
                    Console.WriteLine("Pierwiastek kwadratowy: " + Math.Sqrt(a));
                else
                    Console.WriteLine("Błąd: pierwiastek z liczby ujemnej");
                break;
            case 7:
                Console.WriteLine("Sinus: " + Math.Sin(a));
                break;
            case 8:
                Console.WriteLine("Cosinus: " + Math.Cos(a));
                break;
            case 9:
                Console.WriteLine("Tangens: " + Math.Tan(a));
                break;
            default:
                Console.WriteLine("Nieprawidłowy wybór.");
                break;
        }
    }
}

void zadanie3()
{
    double[] liczby = new double[10];

    Console.WriteLine("Wprowadź 10 liczb rzeczywistych:");
    for (int i = 0; i < liczby.Length; i++)
    {
        Console.Write($"Liczba {i + 1}: ");
        liczby[i] = Convert.ToDouble(Console.ReadLine());
    }

    Console.WriteLine("\nTablica od pierwszego do ostatniego indeksu:");
    for (int i = 0; i < liczby.Length; i++)
    {
        Console.Write(liczby[i] + " ");
    }

    Console.WriteLine("\n\nTablica od ostatniego do pierwszego indeksu:");
    for (int i = liczby.Length - 1; i >= 0; i--)
    {
        Console.Write(liczby[i] + " ");
    }

    Console.WriteLine("\n\nElementy o nieparzystych indeksach:");
    for (int i = 1; i < liczby.Length; i += 2)
    {
        Console.Write(liczby[i] + " ");
    }

    Console.WriteLine("\n\nElementy o parzystych indeksach:");
    for (int i = 0; i < liczby.Length; i += 2)
    {
        Console.Write(liczby[i] + " ");
    }
}

void zadanie4()
{
    double[] liczby = new double[10];

    Console.WriteLine("Wprowadź 10 liczb:");
    for (int i = 0; i < liczby.Length; i++)
    {
        Console.Write($"Liczba {i + 1}: ");
        liczby[i] = Convert.ToDouble(Console.ReadLine());
    }

    double suma = 0;
    double iloczyn = 1;
    double min = liczby[0];
    double max = liczby[0];

    for (int i = 0; i < liczby.Length; i++)
    {
        suma += liczby[i];
        iloczyn *= liczby[i];
        if (liczby[i] < min) min = liczby[i];
        if (liczby[i] > max) max = liczby[i];
    }

    double srednia = suma / liczby.Length;

    Console.WriteLine("\nWyniki:");
    Console.WriteLine("Suma elementów: " + suma);
    Console.WriteLine("Iloczyn elementów: " + iloczyn);
    Console.WriteLine("Wartość średnia: " + srednia);
    Console.WriteLine("Wartość minimalna: " + min);
    Console.WriteLine("Wartość maksymalna: " + max);
}

void zadanie5()
{
    for (int i = 20; i >= 0; i--)
    {
        if (i == 2 || i == 6 || i == 9 || i == 15 || i == 19)
        {
            continue;
        }
        Console.WriteLine(i);
    }
}

void zadanie6()
{
    while (true)
    {
        Console.Write("Podaj liczbę całkowitą: ");
        int liczba = Convert.ToInt32(Console.ReadLine());

        if (liczba < 0)
        {
            break;
        }
    }
}

void zadanie7()
{
    Console.Write("Podaj liczbę elementów do posortowania: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int[] liczby = new int[n];
    Console.WriteLine("Wprowadź liczby:");
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Element {i + 1}: ");
        liczby[i] = Convert.ToInt32(Console.ReadLine());
    }

    for (int i = 0; i < liczby.Length - 1; i++)
    {
        for (int j = 0; j < liczby.Length - i - 1; j++)
        {
            if (liczby[j] > liczby[j + 1])
            {
                int temp = liczby[j];
                liczby[j] = liczby[j + 1];
                liczby[j + 1] = temp;
            }
        }
    }

    Console.WriteLine("\nPosortowane liczby:");
    foreach (var liczba in liczby)
    {
        Console.WriteLine(liczba);
    }
}

//zadanie1();
zadanie2();
//zadanie3();
//zadanie4();
//zadanie5();
//zadanie6();
//zadanie7();
