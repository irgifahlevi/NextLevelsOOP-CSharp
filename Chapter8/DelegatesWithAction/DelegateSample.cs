namespace DelegatesWithAction
{
    public static class DelegateSample
    {
        // Deklarasi delegate bernama Del yang menerima sebuah string sebagai parameter 
        // dan tidak mengembalikan nilai.
        public delegate void Del(string input);

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

        // Metode yang memicu event SomethingHappened.
        public static void DoSomething()
        {
            System.Console.WriteLine("I'm about to do something.");

            // Memeriksa apakah event SomethingHappened memiliki subscriber sebelum memicunya.
            if (SomethingHappened != null)
            {
                // Memanggil event dengan memberikan pesan "I did something" sebagai argumen.
                SomethingHappened("I did something");
            }
        }
    }
}