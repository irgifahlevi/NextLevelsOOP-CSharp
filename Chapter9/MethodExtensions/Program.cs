// See https://aka.ms/new-console-template for more information

using MethodExtensions;

var character = StringExtensionsSample.Right("Hello world", 5);
System.Console.WriteLine(character);

string name = "Jane Black";
// Dengan adanya kata kunci this string, kita dapat memanggil Right pada objek myString, 
// meskipun sebenarnya Right adalah metode ekstensi.
System.Console.WriteLine(name.Right(5));
