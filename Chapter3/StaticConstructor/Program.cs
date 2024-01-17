// See https://aka.ms/new-console-template for more information
// instance class MyClass
using StaticConstructor;

// instance the class MyClass
MyClass mc = new MyClass();
Console.WriteLine($"{MyClass.LastCaller}");
Console.WriteLine($"{MyClass.CallCounter}");

// call the methods
mc.MethodA();
MyClass.MethodB();
mc.MethodA();
MyClass.MethodB();


// print output
Console.WriteLine($"{MyClass.LastCaller}");
Console.WriteLine($"{MyClass.CallCounter}");
