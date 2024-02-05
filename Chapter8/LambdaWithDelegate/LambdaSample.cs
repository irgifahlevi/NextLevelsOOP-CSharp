namespace LambdaWithDelegate
{
    public static class LambdaSample
    {
        // Event delegate yang menggunakan Action<string> sebagai tipe delegate.
        public static event Action<string>? SomethingHappened;

        // Metode yang menerima parameter delegate Action<string>.
        public static void PassMeWork(Action<string> work)
        {
            // Memanggil delegate yang diterima dengan argumen "delegate".
            work("delegate");
        }

        /// <summary>
        /// Func<string, int> adalah tipe delegate generik yang dapat menerima argumen 
        /// bertipe string dan mengembalikan nilai bertipe int.
        /// </summary>
        public static void PassMeLogic(Func<string, int> worker)
        {
            // Memanggil delegate yang diterima dengan argumen "Hello worlds" dan mendapatkan hasil kembalian.
            int count = worker("Hello worlds");
            System.Console.WriteLine($"Function returned {count}");
        }

    }
}