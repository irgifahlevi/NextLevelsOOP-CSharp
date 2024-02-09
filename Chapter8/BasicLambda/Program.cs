// See https://aka.ms/new-console-template for more information
namespace BasicLambda
{
    // Deklarasi delegate 
    public delegate int MyDelegate1(int input);
    public delegate void MyDelegate2(int input, string prefix);
    public delegate bool MyDelegate3(int input);
    public class Program
    {
        public static void Main(string[] args)
        {
            ///<summary>
            /// Lambda merupakan anonymous method
            ///</summary>

            // Single argument lambda
            MyDelegate1 d1 = (x) => x * x;
            System.Console.WriteLine("The result of d1 is : {0}", d1(10));

            // dynamic change delegate 
            int b = 20;
            d1 = (a) => a * b;
            System.Console.WriteLine("The result of d1 is : {0}", d1(10));

            // multiple arguments
            MyDelegate2 d2 = (x, y) =>
            {
                System.Console.WriteLine("The two arguments lambdas : {0}, {1}", x * b, y);
            };
            d2(12, "Hello form multiple args");

            // expression delegate 
            MyDelegate3 d3 = (x) => x >= b;
            System.Console.WriteLine($"Calling d3 with tresshold : 10 is : {d3(12)}");
            System.Console.WriteLine($"Calling d3 with tresshold : 10 is : {d3(7)}");
        }
    }
}