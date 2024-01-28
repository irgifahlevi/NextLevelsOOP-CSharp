// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;
using StatmentIfAndSwitch;

// deklarasi variable yang dapat menerima null (string?)
string? input = "something";

// deklarasi variable yang tidak menerima null, 
int definiteInt;

// eplisit deklarasi variable yang dapat menerima null (int?)
int? age = null;


Nullable<int> age2 = null;

age = 5;
age ??= 12;
definiteInt = age ?? 17;

//definiteInt = age != null ? age.Value : 17;

Console.WriteLine($"Age is: {definiteInt}");
Console.WriteLine(PadAndTrim(input, 15, '0'));


static string PadAndTrim([AllowNull] string input, int length, char padChar)
{
    if (input == null)
    {
        // jika input null di kembalikan string kosong dan di isi padChar dengan panjang 15
        return String.Empty.PadLeft(length, padChar);
    }
    // jika input tidak sama dengan null dan panjang input kurang dari sama dengan length
    else if (input != null && input.Length <= length)
    {

        /// <summary>
        ///  switch statment
        /// </summary>
        // pilihan padChar
        switch (padChar)
        {
            // jika padChar ' ' and '|'
            case ' ':
            case '|':
                // melakukan operasi Trim() untuk menghapus spasi di awal dan akhir input 
                return input.Trim().PadLeft(length, padChar);
            // jika padChar '0' and '9'
            case '0':
            case '9':
                // melakukan operasi Trim() untuk menghapus spasi di awal dan akhir input 
                return input.Trim().PadRight(length, padChar);
            // jika tidak ada pilihan di set default
            default:
                System.Console.WriteLine("No match for padChar");
                // selesai
                break;
        }

        // melakukan operasi Trim() untuk menghapus spasi di awal dan akhir input 
        return input.Trim().PadLeft(length, padChar);

    }
    else
    {
        throw new ArgumentException("Input is longer than requested length");
    }
}

var shiftDay = GetShiftDays(DateTime.Now.DayOfWeek);
//var shiftDay = GetShiftDays((DayOfWeek)17); // invalid
System.Console.WriteLine(shiftDay);


/// <summary>
///  Switch ekspression
/// </summary>
static ShiftDays GetShiftDays(DayOfWeek day) => day switch
{
    DayOfWeek.Monday => ShiftDays.Monday,
    DayOfWeek.Tuesday => ShiftDays.Tuesday,
    DayOfWeek.Wednesday => ShiftDays.Wednesday,
    DayOfWeek.Thursday => ShiftDays.Thursday,
    DayOfWeek.Friday => ShiftDays.Friday,
    DayOfWeek.Saturday => ShiftDays.Saturday,
    DayOfWeek.Sunday => ShiftDays.Sunday,
    _ => throw new ArgumentException("Invalid day of week supplied")
};


// Using ekspression
IPerson sw = new ShiftWorker { FirstName = "Shift", LastName = "Worker", StartDate = new DateOnly(2020, 7, 15) };
IPerson mgr = new Manager { FirstName = "Manager", LastName = "Worker", NumberOfDirectReports = 7 };

Console.WriteLine(GetPersonDetails(sw));
Console.WriteLine(GetPersonDetails(mgr));

// mengambil parameter interface IPerson yang disebut p
static string GetPersonDetails(IPerson p)
{

    /// <summary>
    /// Menggunakan pattern matching, dengan menggunakan is dan declaration 
    /// pattern (ShiftWorker swv dan Manager mgr).
    /// </summary>

    // Jika p adalah ShiftWorker
    if (p is ShiftWorker swv)
    {
        return $"{swv.FirstName} {swv.LastName}: {swv.StartDate}";
    }
    // Jika p adalah Manager
    else if (p is Manager mgr)
    {
        return $"{mgr.FirstName} {mgr.LastName} Reports: {mgr.NumberOfDirectReports}";
    }
    return String.Empty;
}

