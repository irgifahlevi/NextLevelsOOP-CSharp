// See https://aka.ms/new-console-template for more information

// lambda sample
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