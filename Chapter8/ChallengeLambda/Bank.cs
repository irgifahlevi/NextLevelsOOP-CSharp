namespace ChallengeLambda
{
    // Deklarasi delegate dengan signature void, parameter decimal value
    public delegate void BalanceDelegate(decimal value);
    public static class Bank
    {
        // Dekalarasi events static 
        public static event BalanceDelegate balanceEvents;

        // Private member
        private static decimal bankBalance;

        // Public member untuk akses balance dari kelas Bank
        public static decimal Balance
        {
            set
            {
                bankBalance = value;

                // invoke events dan memicu events apabila saldo baru masuk
                balanceEvents(bankBalance);
            }
            get
            {
                // mengembalikan saldo
                return bankBalance;
            }
        }
    }
}