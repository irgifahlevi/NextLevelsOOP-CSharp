// See https://aka.ms/new-console-template for more information
using Inerhitance;

#region Call Class
Circle circle = new Circle(2);
Rectangle rectangle = new Rectangle(10, 10);
Square square = new Square(2);

// Console.WriteLine($"{shape2D}");
// Console.WriteLine($"{circle}");
Console.WriteLine($"{circle.GetAreas()}");
Console.WriteLine($"{rectangle.GetAreas()}");
Console.WriteLine($"{square.GetAreas()}");

#region Method
void PrintArea(Shape2D shape)
{
    var data = shape.GetAreas();
    Console.WriteLine($"{data}");
}
#endregion

PrintArea(circle);
PrintArea(rectangle);
PrintArea(square);
#endregion
