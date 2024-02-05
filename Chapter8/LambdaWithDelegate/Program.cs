// See https://aka.ms/new-console-template for more information

// lambda sample
using LambdaWithDelegate;

var t = (string s) => System.Console.WriteLine(s);
var j = (string s) => s.Length;

// invoke t
t("Hello dude!");
j("Hello");

// lambda multiple statment
var a = (string s) =>
{
    System.Console.WriteLine(s);
    return s.Length;
};

// invoke a
a("Hello friends :D");

/// <summary>
/// lambda dalam C# digunakan untuk membuat metode anonim, 
/// yang juga dikenal sebagai metode lambda atau fungsi lambda. 
/// </summary>

// using delegate lambda
LambdaSample.PassMeWork(
    (s) => Console.WriteLine("Hello from lambda " + s));

LambdaSample.PassMeLogic((s) =>
{
    Console.WriteLine(s);
    return s.Length;
});

// new instance class player
Player p = new Player(1, "Joe", 100);
Console.WriteLine(p);

