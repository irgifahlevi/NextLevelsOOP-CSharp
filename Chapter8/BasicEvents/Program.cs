// See https://aka.ms/new-console-template for more information
using BasicEvents;

// instance event publisher
EventPublisher obj = new EventPublisher();

// mendaftarkan dan mengaitkan method ke dalam event
obj.valueChanged += new MyEventHandler(Changed);
obj.valueChanged += ChangedMessage;

// mendaftarkan dan mengaitkan anonymous delegate an event
obj.valueChanged += delegate (string msg)
{
    System.Console.WriteLine($"The value from anonymous delegate {msg}");
};



/// <summary>
/// Ketika objChanged event dipicu, handler ini akan dijalankan.
/// Handler ini mencetak pesan yang memberi tahu tentang perubahan properti yang terjadi pada objek pengirim.
/// send.GetType() digunakan untuk mendapatkan tipe objek pengirim event (misalnya, classnya) dan
/// e.propChanged digunakan untuk mendapatkan nilai properti yang berubah dari argumen event.
/// </summary>

obj.objChanged += delegate (object send, ChangeEventsArgs e)
{
    System.Console.WriteLine($"{send.GetType()} had the {e.propChanged} property changed");
};

string value;

do
{
    System.Console.WriteLine("Enter the value : ");
    value = Console.ReadLine();

    // Jika value ada dan tidka sama dengan exit
    if (value != null && !value.Equals("exit"))
    {
        // memasukan value ke dalam object value
        obj.Value = value;
    }

    // akan melooping jika value tidak sama dengan exit
} while (!value.Equals("exit"));
System.Console.WriteLine("Goodbye!");


static void Changed(string message)
{
    System.Console.WriteLine($"The value changed to {message}");
}

static void ChangedMessage(string msg)
{
    System.Console.WriteLine($"The value changed 2 {msg}");
}
