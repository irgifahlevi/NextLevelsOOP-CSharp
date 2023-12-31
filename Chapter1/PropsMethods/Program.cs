// See https://aka.ms/new-console-template for more information
using PropsMethods;
#region Calling Class
try
{
    Rectangle rectangle1 = new Rectangle(10, -9);
    Rectangle rectangle2 = new Rectangle(10);
    // rectangle1.Width = 10;
    // rectangle1.Height = -1;
    Console.WriteLine($"{rectangle1.GetAreas()}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

#endregion


