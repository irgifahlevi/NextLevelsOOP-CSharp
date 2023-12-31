// See https://aka.ms/new-console-template for more information
using DefineClasses;

#region Calling Clases
Shapes rectangle1 = new Shapes(100, 100);
Shapes rectangle2 = new Shapes(3);
#endregion

Console.WriteLine($"{rectangle1.GetAreas()}");
Console.WriteLine($"{rectangle2.GetAreas()}");


