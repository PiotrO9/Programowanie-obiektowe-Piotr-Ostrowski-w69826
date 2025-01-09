namespace lab2
{
    internal class Sumator
    {
        private int[] liczby;

        public Sumator(int[] liczby)
        {
            this.liczby = liczby;
        }

        public int Suma()
        {
            int suma = 0;
            foreach (var liczba in liczby)
            {
                suma += liczba;
            }
            return suma;
        }

        public int SumaPodziel2()
        {
            int suma = 0;
            foreach (var liczba in liczby)
            {
                if (liczba % 2 == 0)
                {
                    suma += liczba;
                }
            }
            return suma;
        }

        public int IleElementów()
        {
            return liczby.Length;
        }

        public void WypiszWszystkieElementy()
        {
            foreach (var liczba in liczby)
            {
                Console.WriteLine(liczba);
            }
        }

        public void WypiszElementyWZakresie(int lowIndex, int highIndex)
        {
            for (int i = lowIndex; i <= highIndex; i++)
            {
                if (i >= 0 && i < liczby.Length)
                {
                    Console.WriteLine(liczby[i]);
                }
            }
        }
    }
}
