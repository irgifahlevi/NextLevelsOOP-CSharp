// See https://aka.ms/new-console-template for more information
using System.Collections;

string[] names = new string[2];

names[0] = "Hana";
names[1] = "Jane";

//System.Console.WriteLine($"Hello {names[0]}, {names[1]}");
//System.Console.WriteLine("Hello {0}, {1}", names);

var arrList = new ArrayList(2);
arrList.Add("ONE");

arrList.AddRange(new string[] { "TWO", "THEREE", "FOUR" });

System.Console.WriteLine($"Collection count is {arrList.Count}");
System.Console.WriteLine("Index items from collection [2] : {0}", arrList[2]);
System.Console.WriteLine("All item list :");

foreach (var a in arrList)
{
    System.Console.WriteLine($"- {a},");
}

