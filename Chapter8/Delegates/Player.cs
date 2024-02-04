namespace Delegates
{
    public static class Player
    {
        // Deklarasi delegate untuk acara pencapaian (achievements)
        public delegate void AchievementsDelegate(int input);

        // Event delegate untuk notifikasi pencapaian yang terbuka
        public static event AchievementsDelegate? AchievementsUnlocked;

        // Anggota kelas untuk menyimpan total poin pemain
        private static int Points { get; set; }

        // Metode untuk menambahkan poin dan memeriksa pencapaian yang tercapai
        public static void AddPoints(int point)
        {
            // Menambahkan poin ke total pemain
            Points += point;

            // Menampilkan pesan pemberitahuan
            System.Console.WriteLine($"Player earned {point} points. Total points: {Points}");

            // Memeriksa apakah pemain mencapai 100 poin atau lebih
            if (Points >= 100)
            {
                // Mengubah warna konsol untuk menyoroti pencapaian yang terbuka
                Console.ForegroundColor = ConsoleColor.DarkGreen;

                // Memanggil event AchievementsUnlocked dan memberikan total poin sebagai argumen
                AchievementsUnlocked?.Invoke(Points);

                // Mengembalikan warna konsol ke warna semula
                Console.ResetColor();
            }
        }
    }
}