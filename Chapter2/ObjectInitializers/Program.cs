// See https://aka.ms/new-console-template for more information
using ObjectInitializers;

#region Call Class
List<Dog> dogs = new List<Dog>();
dogs.Add(new Dog { Name = "Jane", Age = 14, IsTrained = false });
dogs.Add(new Dog { Name = "Max", Age = 19, IsTrained = false });

List<Cat> cats = new List<Cat>();
cats.Add(new Cat { Name = "Pussy", Age = 2, IsDeclawed = true });
cats.Add(new Cat { Name = "Mekly", Age = 4, IsDeclawed = false });


#endregion
Console.WriteLine("This is Dogs: ");
foreach (Dog d in dogs)
{
    Console.WriteLine($"Dog Name : {d.Name}, Dog Age : {d.Age}");
}
Console.WriteLine("This is Cats: ");
foreach (Cat c in cats)
{
    Console.WriteLine($"Cat Name : {c.Name}, Cat Age : {c.Age}");
}

// anonymous types
int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };
Console.WriteLine($"{numbers.Length}");

Owner petOwner = new Owner()
{
    OwnerName = "Jacob",
    Address = "Cannada No.45",
    Pets = new List<Pet> {
        new Dog { Name = "Max", Age = 2},
        new Dog { Name = "Mix", Age = 4},
        new Cat { Name = "Pussy", Age = 1},
        new Cat { Name = "Mekli", Age = 2},
    }
};

Console.WriteLine($"This owner Name : {petOwner.OwnerName}");
foreach (Pet o in petOwner.Pets)
{
    Console.WriteLine($"Pet Name : {o.Name}, Pet Age : {o.Age}");
}



// multiple lists
List<Owner> owners = new List<Owner>();

owners.Add(
    new Owner
    {
        OwnerName = "Jhon Doe",
        Address = "Texas",
        Pets = new List<Pet> {
            new Dog { Name = "Max", Age = 2},
            new Dog { Name = "Mix", Age = 4},
            new Cat { Name = "Pussy", Age = 1},
            new Cat { Name = "Mekli", Age = 2},
        }
    }
);
owners.Add(
    new Owner
    {
        OwnerName = "Marry",
        Address = "Washington",
        Pets = new List<Pet> {
            new Dog { Name = "Lucas", Age = 3},
            new Dog { Name = "Fredoo", Age = 1},
            new Cat { Name = "Melly", Age = 6},
        }
    }
);
owners.Add(
    new Owner
    {
        OwnerName = "Brandon",
        Address = "American",
        Pets = new List<Pet> {
            new Dog { Name = "Daniel", Age = 3},
            new Dog { Name = "Pugh", Age = 5},
            new Cat { Name = "Meoww", Age = 1},
            new Cat { Name = "Jane", Age = 2},
        }
    }
);

Console.WriteLine($"This owner list :");
foreach (Owner o in owners)
{
    Console.WriteLine($"Owner Name : {o.OwnerName}, Addres : {o.Address}");
    foreach (Pet p in o.Pets)
    {
        Console.WriteLine($"Pet Name : {p.Name}, Pet Age : {p.Age}");
    }
}
// Console.WriteLine($"{listDog}");
// Console.WriteLine($"{listDog}");
