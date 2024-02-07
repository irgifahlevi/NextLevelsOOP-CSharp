namespace BasicDelegate
{
    public static class ComposableDelegate
    {
        public delegate void MyDelegateComposable(int arg1, int arg2);


        public static void Method1(int arg1, int arg2)
        {
            string result = (arg1 + arg2).ToString();
            System.Console.WriteLine($"The number from method1 is : {result}");
        }
        public static void Method2(int arg1, int arg2)
        {
            string result = (arg1 * arg2).ToString();
            System.Console.WriteLine($"The number from method2 is : {result}");
        }
    }
}