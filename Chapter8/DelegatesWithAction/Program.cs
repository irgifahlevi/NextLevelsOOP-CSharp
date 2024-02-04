// See https://aka.ms/new-console-template for more information

using DelegatesWithAction;

DelegateSample.PassMeWork(myMethod);


static void myMethod(string name)
{
    System.Console.WriteLine($"Action in action : {name}");
}

// Memanggil PassMeLogic dan menyertakan StringLengthFunction sebagai argumen.
DelegateSample.PassMeLogic(CountLength);

// Membuat sebuah metode yang sesuai dengan tipe delegate Func<string, int>.
static int CountLength(string input)
{
    return input.Length;
}
