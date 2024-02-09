// See https://aka.ms/new-console-template for more information

using ChallengeLambda;

// medaftarkan dan mengaitkan anonymous method (lambda) ke dalam event delegate
Bank.balanceEvents += (amount) =>
{
    System.Console.WriteLine($"The balance amount is {amount}");
};
Bank.balanceEvents += (amount) =>
{
    if (amount > 500.0m)
    {
        System.Console.WriteLine($"You reached saving goals!, you have amount : {amount}");
    }
};

string input;
do
{
    System.Console.WriteLine("How much to deposit?");
    input = Console.ReadLine();
    if (!string.IsNullOrEmpty(input) && !input.Equals("exit"))
    {
        // convert string to decimal
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
