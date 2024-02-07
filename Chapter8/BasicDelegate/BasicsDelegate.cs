namespace BasicDelegate
{
    public static class BasicsDelegate
    {
        public delegate string MyDelegate(int arg1, int arg2);

        public static string Func1(int a, int b)
        {
            return (a + b).ToString();
        }

        public static string Func2(int a, int b)
        {
            return (a * b).ToString();
        }
    }
}