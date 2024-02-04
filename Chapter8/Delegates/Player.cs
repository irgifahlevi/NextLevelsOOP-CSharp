namespace Delegates
{
    public static class Player
    {
        public delegate void AchievmentsDelegate(int input);

        // Event delegate
        public static event AchievmentsDelegate? AchievmentsUnlocked;

        // Member class
        private static int Points { get; set; }

        public static void AddPoints(int point)
        {
            Points += point;
            System.Console.WriteLine($"Player earned {point} points. Total point : {Points}");
            if (Points >= 100)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                AchievmentsUnlocked?.Invoke(Points);
                Console.ResetColor();
            }
        }
    }
}