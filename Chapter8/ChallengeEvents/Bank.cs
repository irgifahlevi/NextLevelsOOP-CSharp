namespace ChallengeEvents
{
    public delegate void BalanceDelegate(decimal value);
    public static class Bank
    {
        public static event BalanceDelegate balanceEvents;

        private static decimal bankBalance;

        public static decimal Balance
        {
            set
            {
                bankBalance = value;

                // invoke events 
                balanceEvents(bankBalance);
            }
            get
            {
                return bankBalance;
            }
        }
    }
}