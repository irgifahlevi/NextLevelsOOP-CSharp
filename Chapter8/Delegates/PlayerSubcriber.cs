namespace Delegates
{
    public static class PlayerSubcriber
    {
        public static void SubcriberPlayerSend(int point)
        {
            System.Console.WriteLine($"Hello from player subcriber, your earned points : {point}");
        }
    }
}