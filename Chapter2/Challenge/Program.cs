// See https://aka.ms/new-console-template for more information
using Challenge;
#region Calling Class
Salaries Emp1 = new Salaries() { ID = 1, FullName = "Lucas", Departement = "Division", Salary = 100 };
Hours Emp2 = new Hours() { ID = 2, FullName = "Betrand", Departement = "Legal Dept", PayRate = 35 };

Console.WriteLine($"{Emp1} -- {Emp1.Salary:C2}");
Emp1.Departement = "Management";
Emp1.JustPay(100);
Console.WriteLine($"{Emp1} -- {Emp1.Salary:C2}");

Console.WriteLine("-----------------------------");

Console.WriteLine($"{Emp2} -- {Emp2.PayRate:C2}");
Emp2.Departement = "Management";
Emp2.JustPay(100);
Console.WriteLine($"{Emp2} -- {Emp2.PayRate:C2}");
#endregion

