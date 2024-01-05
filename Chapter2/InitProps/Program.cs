// See https://aka.ms/new-console-template for more information
using InitProps;

#region Calling Class
// create object using initializers
Employee emp1 = new Employee()
{
    ID = 1, // Menggunakan init untuk menginisialisasi nilai ID
    FirstName = "Mike",
    LastName = "Tyson",
    Departement = "CIS"
};

// create object using constructors
Employee emp2 = new Employee(2, "Joe", "Month", "DIV");

Console.WriteLine($"{emp1}");
emp1.Departement = "Support";
//emp1.ID = 5;     karena ID adalah inisialisasi hanya-properti
Console.WriteLine($"{emp1}");

Console.WriteLine(emp2);
emp2.LastName = "Dough";
//emp2.ID = 3;
Console.WriteLine(emp2);
#endregion

