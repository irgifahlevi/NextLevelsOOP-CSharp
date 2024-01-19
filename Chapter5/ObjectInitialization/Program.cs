// See https://aka.ms/new-console-template for more information
// instance class Employee
using ObjectInitialization;

// memanggil constructor default
Employee employee = new Employee()
{
    FirstName = "Jane",
    LastName = "Joue",
    EmployeeId = 2,
    StartDate = new DateOnly(2024, 1, 19)
};

// Memanggil constructor dengan parameter
Employee emp = new Employee("Jane", "Lucas", 4)
{
    StartDate = new DateOnly(2024, 1, 19)
};

//Console.WriteLine($"Hello my name {emp.LastName} {emp.LastName} id {emp.EmployeeId}");


Age age = new Age()
{
    BirthDate = new DateTime(20),
    YearsOld = 12
};

// Console.WriteLine($"Hello my name {age.BirthDate} {age.YearsOld}");


PremiereCustomer pCust = new PremiereCustomer(2);
pCust.FirstName = "Harry";

// tidak bisa di ubah atau di gunakan
// pCust.CustomerLevel = 3;
//Console.WriteLine($"This customer name {pCust.FirstName} and level {pCust.CustomerLevel}");


Manager manager = new Manager("Clark", "Thomson");
//manager.NumberOfDirectReports = 2;
manager.SetReports(3);

Console.WriteLine($"{manager}");






