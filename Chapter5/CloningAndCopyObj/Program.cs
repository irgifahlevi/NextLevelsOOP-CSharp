// See https://aka.ms/new-console-template for more information
using CloningAndCopyObj;
// memanggil method
//Classes();
//Structs();
Records();


static void Classes()
{
    Console.WriteLine("=========== Classes = reference types ===========");
    // instance new object employe
    Employee me = new Employee
    {
        FirstName = "Matt",
        LastName = "Milner",
        Age = new Age { BirthDate = new DateTime(1971, 9, 1), YearsOld = 50 },
        Id = 1
    };

    //create another reference to the employee
    IPerson other = me;
    other.FirstName = "Bizarro Matt";
    other.Age = new Age { BirthDate = new DateTime(1980, 9, 1), YearsOld = 39 };

    //examine results of the original object
    Console.WriteLine($"{me.FirstName} is {me.Age.YearsOld} but {other.FirstName} is {other.Age.YearsOld}");
    Console.WriteLine();

    /// <summary>
    /// penggunaan ref pada parameter metode memungkinkan perubahan pada objek yang dikirimkan ke metode 
    /// tersebut mencerminkan perubahan pada objek yang menjadi referensi di luar metode.
    /// </summary>
    /// <value>ref</value>
    ChangeName(other);

    Console.WriteLine($"{other.FirstName} {other.LastName} is still {other.Age.YearsOld}");

    Console.WriteLine();
}

static void ChangeName(IPerson person)
{
    /// <summary>
    /// penggunaan ref pada parameter metode memungkinkan perubahan pada objek yang dikirimkan ke metode 
    /// tersebut mencerminkan perubahan pada objek yang menjadi referensi di luar metode.
    /// </summary>
    person.LastName = "Unknown";
    Console.WriteLine($"Person in method is {person.FirstName} {person.LastName}");

    person = new Manager("Manager", "Milner")
    {
        Id = 2,
        Age =
        new Age { BirthDate = new DateTime(1990, 1, 1), YearsOld = 31 }
    };

    Console.WriteLine($"Person after reference change in method is {person.FirstName}");
}



static void Structs()
{
    Console.WriteLine("=========== Structs = value types ===========");

    Age myAge = new Age { BirthDate = new DateTime(1971, 9, 1), YearsOld = 50 };
    Age anotherAge = myAge;

    anotherAge.YearsOld = 39;

    Console.WriteLine($"My age is {myAge.YearsOld}, but I changed it to {anotherAge.YearsOld}");

    /// <summary>
    /// penggunaan ref pada parameter metode memungkinkan perubahan pada objek yang dikirimkan ke metode 
    /// tersebut mencerminkan perubahan pada objek yang menjadi referensi di luar metode.
    /// </summary>
    AgeBackwords(ref anotherAge, 5);
    // results AnotherAge = 34
    Console.WriteLine($"Now I am {anotherAge.YearsOld}");
    Console.WriteLine();
}

static void AgeBackwords(ref Age startingAge, int numberOfYearsToAge)
{
    /// <summary>
    /// ref mengembalikan perubahan pada objek yang menjadi referensi di luar metode.
    /// </summary>
    startingAge.YearsOld = startingAge.YearsOld - numberOfYearsToAge;
    // this logic 39 - 5
    Console.WriteLine($"Modified age in method: {startingAge.YearsOld}");
}

static void Records()
{
    Console.WriteLine("=========== Records = reference or value types ===========");

    PremiereCustomer pc = new PremiereCustomer
    {
        FirstName = "Customer",
        LastName = "One",
        Id = 7,
        Age = new Age { BirthDate = DateTime.Now, YearsOld = 1 },
        CustomerLevel = 1
    };

    /// <summary>
    /// Menggunakan with untuk membuat salinan objek pc dengan beberapa perubahan. 
    /// Dalam hal ini, CustomerLevel diubah menjadi 2 dan LastName menjadi "Two".
    /// </summary>
    PremiereCustomer pc2 = pc with { CustomerLevel = 2, LastName = "Two" };

    Console.WriteLine($"{pc.FirstName} {pc.LastName} has a level of {pc.CustomerLevel}");
    Console.WriteLine($"{pc2.FirstName} {pc2.LastName} has a level of {pc2.CustomerLevel}");
    // Mengkonversi objek pc menjadi tipe IPerson dan kemudian meneruskan
    // objek tersebut ke metode ChangeName & tidak menggunakan ref
    ChangeName((IPerson)pc);
    Console.WriteLine($"{pc.FirstName} {pc.LastName} is still {pc.Age.YearsOld}");

}






