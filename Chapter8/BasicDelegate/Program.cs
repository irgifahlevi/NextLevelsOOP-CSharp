// See https://aka.ms/new-console-template for more information
using BasicDelegate;

// menggunakan top level statments class Main
public class Program
{
    public static void Main(string[] args)
    {
        // declare method statis
        var Funct1 = BasicsDelegate.Func1;
        var Funct2 = BasicsDelegate.Func2;

        // Membuat instance dari delegasi MyDelegate menggunakan metode statis Func1 & Func2
        BasicsDelegate.MyDelegate myDelegate1 = new BasicsDelegate.MyDelegate(Funct1);
        BasicsDelegate.MyDelegate myDelegate2 = new BasicsDelegate.MyDelegate(Funct2);
        BasicsDelegate.MyDelegate myDelegate3 = new BasicsDelegate.MyDelegate(MyClass.InstanceMethod1);


        string res = myDelegate1(10, 20);
        System.Console.WriteLine($"The number from funct1 : {res}");

        res = myDelegate2(10, 20);
        System.Console.WriteLine($"The number from funct2 : {res}");

        System.Console.WriteLine($"The number from instanceMethod1 : {myDelegate3(10, 20)}");
    }
}

