// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;
using DefiningTypes;

// Instance the class Myclass

Employee emp = new Manager("Jane", "Martin");
Console.WriteLine($"Hello my name is {emp.FirstName}");

Manager m = new Manager("Jerrman", "Huda");
m.FirstName = "Clark";
m.LastName = "Jarry";
Console.WriteLine($"{m}");

// Customer cus = new Customer() { FirstName = "Ali", LastName = "Herx" };
// Console.WriteLine($"{cus}");
// cus.FirstName = "July";
// Console.WriteLine($"{cus}");