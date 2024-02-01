// See https://aka.ms/new-console-template for more information
using System.Collections;
using Collections;

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

System.Console.WriteLine("========= Using Collection Example =========");
System.Console.WriteLine();
System.Console.WriteLine();
// Colection sample
CollectionSamples.Queue("A", "B", "C"); // FIFO (First In First Out)
CollectionSamples.Stack("A", "B", "C"); // LIFO (Last In First Out)

// using stack Generic
CollectionSamples.StackGeneric("A", "B", "C", "D");
var custom = new CustomStack<string>();

custom.MyPush(new string[] { "AA", "BB", "CC" });
System.Console.WriteLine("Stac elements");
while (custom.Count() > 0)
{
    custom.MyPop();
}

System.Console.WriteLine("========= Working With Collection =========");
System.Console.WriteLine();
System.Console.WriteLine();

MyCollections.Indexing();
MyCollections.Iterating();


