namespace lab2
{
    internal class Licz
    {
        private double value;

        public Licz(double initialValue)
        {
            value = initialValue;
        }

        public void Dodaj(double amount)
        {
            value += amount;
        }

        public void Odejmij(double amount)
        {
            value -= amount;
        }

        public void WypiszStan()
        {
            Console.WriteLine($"Wartość: {value}");
        }
    }
}
