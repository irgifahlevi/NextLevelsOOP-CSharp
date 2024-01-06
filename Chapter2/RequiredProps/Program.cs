// See https://aka.ms/new-console-template for more information
using RequiredProps;

#region Calling Class

// membuat object dengan constructor initializers
Person emp1 = new Person() { ID = 1, FirstName = "Joe", LastName = "Dhoe", Departement = "Salles" };
Person emp2 = new Person() { ID = 2, FirstName = "Marry", LastName = "Mell", Departement = "Marketing" };
Person emp3 = new Person() { ID = 3, FirstName = "Billy", LastName = "Carrk", Departement = "Project Manager" };


// membuat object dengan constructor
Person emp4 = new Person(4, "Jhon", "Key", "Marketing");
Console.WriteLine($"{emp1}");
Console.WriteLine($"{emp2}");
Console.WriteLine($"{emp3}");
Console.WriteLine($"{emp4}");
#endregion


