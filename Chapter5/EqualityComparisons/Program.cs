// See https://aka.ms/new-console-template for more information
using EqualityComparisons;

Classes();
Structs();
Records();

static void Classes()
{
    Console.WriteLine("=================Classes=================");
    CPoint p1 = new CPoint { X = 7, Y = 3 };
    CPoint p2 = p1;

    // akan menghasilkan true karena p1 dan p2 merupakan object yang sama
    Console.WriteLine($"P1 = P2: {p1 == p2}");

    CPoint p3 = new CPoint { X = 7, Y = 3 };

    // akan menghasilkan false karena p1 dan p3 merupakan object yang berbeda
    Console.WriteLine($"P1 = P3: {p1 == p3}");
    Console.WriteLine();
}

static void Structs()
{
    Console.WriteLine("=================Structs=================");
    SPoint p1 = new SPoint { X = 7, Y = 3 };
    SPoint p2 = p1;

    // operator == tidak dapat di gunakan secara langsung pada property struct yang memiliki properti 
    // dengan penulisan set. Dalam struct, properti yang menggunakan penulisan set menyebabkan 
    // struct tersebut dianggap tidak dapat diubah (immutable),
    //Console.WriteLine($"P1 = P2: {p1 == p2}");

    Console.WriteLine($"P1 = P2: {p1 == p2}");
    SPoint p3 = new SPoint { X = 7, Y = 3 };

    Console.WriteLine($"P1 = P3: {p1.Equals(p3)}");
    Console.WriteLine();
}

static void Records()
{
    Console.WriteLine("=================Records=================");
    RPoint p1 = new RPoint(7, 3);
    RPoint p2 = p1;

    Console.WriteLine($"P1 = P2: {p1 == p2}");

    RPoint p3 = new RPoint(7, 3);

    Console.WriteLine($"P1 = P3: {p1 == p3}");
}
