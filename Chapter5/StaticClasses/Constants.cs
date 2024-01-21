namespace StaticClasses
{
    /// <summary>
    /// Kelas statis digunakan untuk menyimpan konstanta dan metode statis.
    /// Kelas ini menyediakan nilai-nilai konstanta dan operasi-operasi yang berkaitan 
    /// dengan konstanta tersebut.
    /// </summary>
    static class Constants
    {
        // Connection string untuk menghubungkan ke database.
        private static string connectionString;

        // Konstanta statis yang dapat diakses secara publik untuk nama server konfigurasi.
        public static readonly string CONFIG_SERVER_NAME = "TargetServer";

        // Konstanta statis yang dapat diakses secara publik untuk nama database konfigurasi.
        public const string CONFIG_DB_NAME = "DatabaseName";

        // Properti statis yang dapat diakses secara publik untuk nilai integer yang dapat diatur dan diambil.
        public static int MyProperty { get; set; }

        /// <summary>
        /// Metode statis yang mengonversi DateOnly ke DateTime.
        /// </summary>
        /// <param name="input">Nilai DateOnly yang akan dikonversi.</param>
        /// <returns>Nilai DateTime yang dihasilkan dari DateOnly.</returns>
        public static DateTime GetDateTimeFromDateOnly(DateOnly input)
        {
            return new DateTime(input.Year, input.Month, input.Day);
        }

        // Konstruktor statis yang dijalankan saat kelas ini pertama kali digunakan.
        static Constants()
        {
            Console.WriteLine("Constructor static called");
            connectionString = "Server=..."; //config
        }
    }
}