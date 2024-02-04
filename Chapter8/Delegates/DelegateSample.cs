namespace Delegates
{
    public static class DelegateSample
    {
        // Deklarasi delegate bernama Del yang menerima sebuah string sebagai parameter 
        // dan tidak mengembalikan nilai.
        public delegate void Del(string input);
        public delegate void MyDelegate(string myInput);

        // event delegate
        public static event Del? SomethingHappened;

        // Metode yang mengambil parameter delegate Del sebagai argumen.
        public static void PassMeWork(Del work)
        {
            // Memanggil delegate yang diterima dengan argumen "delegate".
            work("delegate");
        }

        public static void SendMessage(string message)
        {
            // Membuat instance dari delegate dan menghubungkannya dengan metode
            MyDelegate myDelegate = new MyDelegate(PritntMessage);

            // panggil method dengan delegate
            myDelegate(message);
        }

        private static void PritntMessage(string msg)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            System.Console.WriteLine(msg);
            Console.ResetColor();
        }


        // method triger event
        public static void DoSomething()
        {
            System.Console.WriteLine("I'm about to do something.");
            if (SomethingHappened != null)
            {
                SomethingHappened("I did something");
            }
        }
    }
}