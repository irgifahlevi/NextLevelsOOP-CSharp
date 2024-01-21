// See https://aka.ms/new-console-template for more information
using Abstractions;

/// <summary>
/// Membuat instance dari kelas ShiftWorker dan menetapkannya ke variabel dengan tipe Employee.
/// (polymorphism)
/// </summary>
/// <value></value>
Employee sw = new ShiftWorker
{
    FirstName = "staff",
    LastName = "one",
    StartDate = new DateOnly(2014, 2, 17),
    ShiftStartTime = new TimeOnly(8, 30)
};


Console.WriteLine("=============Shift Worker=============");

// mengakses method di class ShiftWorker abstract dari kelas dasar employee
bool payrollProcessed = sw.ProcessPayroll();

sw.Terminate(DateTime.Now);
bool active = sw.IsActive();
Console.WriteLine();


Employee mgr = new Manager
{
    FirstName = "manager",
    LastName = "one",
    NumberOfDirectReports = 7
};

Console.WriteLine("=============Manager=============");

// mengakses method di class manager abstract dari kelas dasar employee
bool mgrPayrollProcessed = mgr.ProcessPayroll();

// memanggil method dari kelas manager
mgr.Terminate(DateTime.Now);

// memanggil method di class employee
bool mgrActive = mgr.IsActive();

