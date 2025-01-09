namespace lab2
{
    internal class BankAccount
    {
        private decimal saldo;

        public BankAccount(string wlasciciel, decimal poczatkoweSaldo)
        {
            Wlasciciel = wlasciciel;
            saldo = poczatkoweSaldo >= 0 ? poczatkoweSaldo : throw new ArgumentException("Początkowe saldo nie może być ujemne.");
        }

        public string Wlasciciel { get; private set; }

        public decimal Saldo
        {
            get { return saldo; }
        }

        public void Wplata(decimal kwota)
        {
            if (kwota <= 0)
                throw new ArgumentException("Kwota wpłaty musi być dodatnia.");

            saldo += kwota;
        }

        public void Wyplata(decimal kwota)
        {
            if (kwota <= 0)
                throw new ArgumentException("Kwota wypłaty musi być dodatnia.");

            if (kwota > saldo)
                throw new InvalidOperationException("Niewystarczające środki na koncie.");

            saldo -= kwota;
        }
    }
}
