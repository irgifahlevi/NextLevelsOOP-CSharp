// See https://aka.ms/new-console-template for more information
// Instance the class Employee
using Challenge;

var Emp1 = new HourlyEmmployee() { FullName = "John Doe", Department = "Sales", PayRate = 35.0m };
var Emp2 = new SalariedEmployee() { FullName = "Jane Deaux", Department = "Marketing", Sallary = 75000.0m };

Console.WriteLine($"Count: {Employee.EmployeeCount}");

var Emp3 = new SalariedEmployee() { FullName = "Jenny Doh", Department = "Engineering", Sallary = 95000.0m };
Console.WriteLine($"Count: {Employee.EmployeeCount}");

var Emp4 = new HourlyEmmployee() { FullName = "Jim Dough", Department = "Tech Support", PayRate = 45.0m };
Console.WriteLine($"Count: {Employee.EmployeeCount}");

Console.WriteLine($"{Emp1}");
Console.WriteLine($"{Emp2}");
Console.WriteLine($"{Emp3}");
Console.WriteLine($"{Emp4}");