// See https://aka.ms/new-console-template for more information

using Delegates;

/// <summary>
/// Delegate merupakan tipe data yang merepresentasikan referensi ke method dengan signature tertentu. 
/// Mereka menyediakan cara untuk mengatasi masalah di mana kita ingin mempassing method sebagai 
/// parameter atau menyimpan referensi ke method untuk dipanggil nanti. 
/// </summary>

Delegate del = WriteHello;
del.DynamicInvoke("Jack");

// method mencetak string
static void WriteHello(string name)
{
    System.Console.WriteLine($"Hello {name}");
}

// method WriteHello dipassing ke metode PassMeWork pada kelas DelegateSample 
// sebagai parameter delegate.
//DelegateSample.PassMeWork(WriteHello);
//DelegateSample.SendMessage("Hello from send message");

// Event delegate
//DelegateSample.SomethingHappened += WriteHello;

//DelegateSample.DoSomething();

System.Console.WriteLine($"Press CTRL + C to cancel");
Console.CancelKeyPress += OnCancel;

// for (int i = 0; i < 100000; i++)
// {
//     System.Console.WriteLine("Writing" + i);
// }

static void OnCancel(object sender, ConsoleCancelEventArgs args)
{
    args.Cancel = true;
}


System.Console.WriteLine();
System.Console.WriteLine("========PLAYER EVENTS DELEGATE========");
System.Console.WriteLine();

Player.AchievmentsUnlocked += OnAchievmentsUnlocked;
Player.AchievmentsUnlocked += PlayerSubcriber.SubcriberPlayerSend;

// Player events and delegate
Player.AddPoints(10);
Player.AddPoints(20);
Player.AddPoints(30);
Player.AddPoints(60);

static void OnAchievmentsUnlocked(int point)
{
    System.Console.WriteLine($"Congratulations! from Program.cs Achievments unlocked for earning {point} points!");
}
