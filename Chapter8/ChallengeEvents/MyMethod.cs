namespace ChallengeEvents
{
    public static class MyMethod
    {
        public static void BalanceLogger(decimal amount)
        {
            System.Console.WriteLine($"The balance amount is {amount}");
        }

        public static void BalanceWatch(decimal amount)
        {
            if (amount >= 500.0m)
            {
                System.Console.WriteLine($"You reached saving goals!, you have {amount}");
            }
        }
    }
}