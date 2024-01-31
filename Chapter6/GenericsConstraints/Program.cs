// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using GenericsConstraints;

// Shorts and compare

// Implements mapper
var cust1 = new Customer
{
    Id = 1,
    FirstName = "Custommer1",
    LastName = "First",
    CreateDate = new DateOnly(2023, 1, 20)
};

var cust2 = new Customer
{
    Id = 3,
    FirstName = "Custommer1",
    LastName = "Second",
    CreateDate = new DateOnly(2023, 1, 20)
};

// implements 
var sorter = new Sorter<Customer>();
// merge 
var customers = new Customer[] { cust1, cust2 };
sorter.Sort(customers);

foreach (var c in customers)
{
    System.Console.WriteLine($"{c.Id}, {c.LastName}");
}



///

