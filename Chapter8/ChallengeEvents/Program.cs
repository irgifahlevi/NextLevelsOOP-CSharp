// See https://aka.ms/new-console-template for more information


using ChallengeEvents;
// medaftarkan dan mengaitkan method ke dalam event delegate
Bank.balanceEvents += MyMethod.BalanceLogger;
Bank.balanceEvents += MyMethod.BalanceWatch;

string input;
do
{
    System.Console.WriteLine("How much to deposit?");
    input = Console.ReadLine();
    if (!string.IsNullOrEmpty(input) && !input.Equals("exit"))
    {
        decimal value = decimal.Parse(input);

        // Meambahkan value ke dalam balance 
        Bank.Balance += value; // ex: a += b to be a = a + b
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        System.Console.WriteLine("Your input not valid");
        Console.ResetColor();
    }
} while (!input.Equals("exit"));
