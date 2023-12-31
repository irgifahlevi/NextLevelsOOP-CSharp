// See https://aka.ms/new-console-template for more information
using AccessModifiers;
#region Calling Class
MyClass myClass1 = new MyClass();
ChildClass childClass = new ChildClass();

Console.WriteLine($"{myClass1.Data}");
myClass1.Function1();
// myClass1.Function1();
// Console.WriteLine($"{myClass1.Data}");

childClass.Function1();
childClass.Function1();
Console.WriteLine($"{childClass.Data}");
childClass.Function3();
Console.WriteLine($"{childClass.Data}");
//Console.WriteLine($"{childClass.Data}");
#endregion
