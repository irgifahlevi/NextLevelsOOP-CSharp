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
DelegateSample.PassMeWork(WriteHello);
DelegateSample.SendMessage("Hello from send message");
