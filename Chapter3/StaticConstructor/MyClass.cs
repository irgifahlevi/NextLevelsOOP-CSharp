namespace StaticConstructor
{
    public class MyClass
    {

        #region Members
        // Variabel statis
        public static long CallCounter;
        public static string LastCaller;
        #endregion

        #region Constructor
        // static construktor (frist called)
        static MyClass()
        {
            CallCounter = 0;
            LastCaller = "None";  // Nilai default untuk LastCaller
            Console.WriteLine("Static constructor has been called");
        }
        // reguler constructor
        public MyClass()
        {
            Console.WriteLine("Regular constructor has been called");
        }
        #endregion

        #region Method
        // Instance Method
        public void MethodA()
        {
            CallCounter++;
            LastCaller = "MethodA";
        }

        // Static method
        public static void MethodB()
        {
            CallCounter++;
            LastCaller = "MethodB";
        }
        #endregion
    }
}