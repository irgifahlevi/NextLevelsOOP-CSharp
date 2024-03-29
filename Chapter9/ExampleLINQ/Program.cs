﻿// See https://aka.ms/new-console-template for more information
// implementasi LINQ

using System.Xml.Linq;
using ExampleLINQ;

var employes = new List<Employee>
{
    new Employee {Id = 1, FirstName = "Andrew", LastName = "Jack", Age = 23, Salary = 3.000},
    new Employee {Id = 2, FirstName = "Mathew", LastName = "Dalia", Age = 45, Salary = 5.000},
    new Employee {Id = 3, FirstName = "Lucas", LastName = "Pethruc", Age = 25, Salary = 4.000},
    new Employee {Id = 4, FirstName = "Lucian", LastName = "Jenifer", Age = 23, Salary = 2.000},
    new Employee {Id = 5, FirstName = "Alex", LastName = "Ujik", Age = 23, Salary = 3.000},
    new Employee {Id = 6, FirstName = "Bondan", LastName = "Prakoso", Age = 45, Salary = 5.000},
};

// linq mwthod
var dataEmploye = employes.Where((e) => e.Salary >= 3.000).Select((em) => new
{
    Id = em.Id,
    FirstName = em.FirstName,
    Age = em.Age,
    Salary = em.Salary
}).ToList();

foreach (var data in dataEmploye)
{
    System.Console.WriteLine($"ID : {data.Id} Name : {data.FirstName} Age : {data.Age} Salary : {data.Salary}");
}

// query expression LINQ
var dataEmployee2 = from emp in employes
                    where emp.Salary >= 3.000 & emp.Salary <= 4.000 // where merupakan criteria
                    orderby emp.Id descending
                    select new { Id = emp.Id, FirstName = emp.FirstName, Age = emp.Age, Salary = emp.Salary };


// Read data xml
var xmlEmployee = XElement.Load("F:\\Project\\DOTNET\\NextLevelsOOP-CSharp\\Chapter9\\ExampleLINQ\\Employes.xml");
if (xmlEmployee != null)
{
    var xEmpLinq = from xE in xmlEmployee.Descendants("Employee")
                   where (int?)xE.Element("Id") > 2
                   orderby (int?)xE.Element("Id") descending
                   select new
                   {
                       FirstName = xE.Element("FirstName"),
                       LastName = xE.Element("LastName"),
                       Salary = xE.Element("Salary"),
                   };


    foreach (var data in xEmpLinq)
    {
        System.Console.WriteLine($"Name : {data.FirstName.Value} {data.LastName.Value}, Salary : {data.Salary.Value}");
    }
}

