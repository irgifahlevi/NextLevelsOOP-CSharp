// See https://aka.ms/new-console-template for more information

using MethodExtensions;

var character = StringExtensionsSample.Right("Hello world", 5);
System.Console.WriteLine(character);

string name = "Jane Black";
// Dengan adanya kata kunci this string, kita dapat memanggil Right pada objek myString, 
// meskipun sebenarnya Right adalah metode ekstensi.
System.Console.WriteLine(name.Right(5));

System.Console.WriteLine();
System.Console.WriteLine("======Extension methods on collections======");
System.Console.WriteLine();

var names = new List<string> { "Jane", "Lucas", "Andrew", "Erick", "Nick", "Tyson", "Clara" };

// mencari length terkecil pada list menggunakan lambda expression
var sorter = names.MinBy((n) => n.Length);
System.Console.WriteLine(sorter);

// mengurutkan name dari yang lenght terkecil menggunakan lambda expression
var orderBy = names.OrderBy((n) => n.Length);
foreach (var data in orderBy)
{
    System.Console.WriteLine(data);
}

// chalenge
int[] numbers = { 4, 7, 1, 9, 2, 5 };
double medianValue = numbers.Median();

System.Console.WriteLine(medianValue);
