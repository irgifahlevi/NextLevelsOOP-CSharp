// See https://aka.ms/new-console-template for more information
using StaticMethods;

Temperature[] temps = { new Temperature(19.1), new Temperature(22.5), new Temperature(21.5), new Temperature(18.6),
new Temperature(23.0), new Temperature(22.6), new Temperature(22.9)};


// Console.WriteLine($"{Temperature.FtoC(72.0):F2}");
// Console.WriteLine($"{Temperature.CtoF(22.0):F2}");


var roomTemps = 0;

foreach (Temperature t in temps)
{
    if (t.IsRoomTemp())
    {
        Console.WriteLine($"{t.Temp}");
        roomTemps++;
    }
}

Console.WriteLine($"{roomTemps}");

Console.WriteLine($"{Temperature.IsRoomTemp(22.0)}");
Console.WriteLine($"{Temperature.IsRoomTemp(17.0)}");
