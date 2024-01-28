// See https://aka.ms/new-console-template for more information
using System;
using EnumTypes;

/// <summary>
/// DayOfWeek merupakan class enum
/// </summary>
var day = DayOfWeek.Monday;
Console.WriteLine($"{day}");

var shiftDay = ShiftDays.Sunday;

/// <summary>
/// Dengan melakukan casting (int)shiftDay, mengambil nilai integer 
/// yang mewakili anggota enum ShiftDays tertentu.
/// </summary>
Console.WriteLine((int)shiftDay); // casting
Console.WriteLine("=============================================");
Console.WriteLine("=============================================");

ShiftWorker worker = new ShiftWorker() { FirstName = "Marry", LastName = "Jane" };
worker.DaysAvailable = ShiftDays.Weekend;

Console.WriteLine($"{worker.DaysAvailable}");
Console.WriteLine("=============================================");
Console.WriteLine("=============================================");
Console.WriteLine();

ShiftWorker worker1 = new ShiftWorker() { FirstName = "Marry", LastName = "Jane" };

// bitwise (OR) '|' merupakan penggabungan enum  
// contoh Enum A = 2 | B = 1 Output = 3 
worker1.DaysAvailable = ShiftDays.Wednesday | ShiftDays.Thursday;

Console.WriteLine($"{worker1.DaysAvailable}");

Console.WriteLine("=============================================");
Console.WriteLine("=============================================");
Console.WriteLine();

ShiftWorker worker2 = new ShiftWorker() { FirstName = "Marry", LastName = "Jane" };

// bitwise (OR) '|' merupakan penggabungan enum  
// contoh (Sunday = 1) + (Saturday = 64) : Weekend = 65
worker2.DaysAvailable = ShiftDays.Sunday | ShiftDays.Saturday;

Console.WriteLine($"{worker2.DaysAvailable}");


Console.WriteLine("=============================================");
Console.WriteLine("=============================================");
Console.WriteLine();

// mengecek apakah instance worker1 ada sihftday monday
bool availableMonday = worker1.DaysAvailable.HasFlag(ShiftDays.Monday);

// bitwise AND (&) untuk memeriksa apakah worker.DaysAvailable mencakup ShiftDays.Saturday.
bool availableSaturday = (worker.DaysAvailable & ShiftDays.Saturday) == ShiftDays.Saturday;

System.Console.WriteLine($"Has available monday {availableMonday}");
System.Console.WriteLine($"Has available saturday {availableSaturday}");


Console.WriteLine("=============================================");
Console.WriteLine("=============================================");
Console.WriteLine();

/// <summary>
/// operator typeof digunaan untuk mendapatkan objek type yang mempresantikan metadata dari sudatu
/// class, enum, interface, struct dll  
/// </summary>

// mengembalikan array string yang berisi semua nama-nama konstan dalam enum ShiftDays.
var shiftDays = Enum.GetNames(typeof(ShiftDays));

// untuk mendapatkan semua nilai enum dari tipe ShiftDays sebagai array dari tipe short
var shifDaysValues = (short[])Enum.GetValues(typeof(ShiftDays));


// menggabungkan semua elemen dalam array shiftDays menjadi satu string
System.Console.WriteLine(String.Join(',', shiftDays));
System.Console.WriteLine(String.Join(',', shifDaysValues));