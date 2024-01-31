// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using Generics;

int x = 5, y = 6;
//Swap(x, y);
//SwapRef(ref x, ref y);
System.Console.WriteLine($"X = {x}, Y = {y}");


// tidak akan mengubah apapun karena tidak menggunakan ref
// static void Swap(object first, object last)
// {
//     object temp = last;
//     last = first;
//     first = temp;
// }

// akan ref akan mengembalikan pertukaran nilai di dalam method 
static void SwapRef(ref int first, ref int last)
{
    int temp = last;
    last = first;
    first = temp;
}


// Implements generics

var p1 = new Person
{
    FirstName = "Marry",
    LastName = "Dhoe",
    Age = 34
};

var p2 = new Person
{
    FirstName = "Jane",
    LastName = "Marshal",
    Age = 34
};


SwapPerson<Person>(ref p1, ref p2);
System.Console.WriteLine($"First Name P1 : {p1.FirstName}");
System.Console.WriteLine($"First Name P2 : {p2.FirstName}");
/// <summary>
/// T merupakan generics
/// Metode SwapPerson memiliki dua parameter bertipe generic T 
/// yang mewakili objek pertama (first) dan objek kedua (last). Selama metode dijalankan
/// </summary>
/// <typeparam name="T"></typeparam>
static void SwapPerson<T>(ref T first, ref T last)
{
    T temp = last;
    last = first;
    first = temp;
}


string strJsonPerson = @"{
    ""Id"":0,
    ""FirstName"":""Matt"",
    ""LastName"":""Jane"",
    ""Age"":23
}";

// JsonSerializer.Deserialize<T> digunakan untuk mengonversi 
// string JSON menjadi objek dari tipe yang ditentukan (Person dalam hal ini).
var convert = JsonSerializer.Deserialize<Person>(strJsonPerson);
System.Console.WriteLine($"First Name = {convert?.FirstName}");



// Implements mapper
var cust = new Customer
{
    Id = 1,
    FirstName = "Custommer1",
    LastName = "First",
    CreateDate = new DateOnly(2023, 1, 20)
};

// implements 
var mapper = new CustomerToPersonMapper();
var person = cust.Map<Person>(mapper); //mapper.Map(cust);
System.Console.WriteLine($"First Name = {person.FirstName}");
