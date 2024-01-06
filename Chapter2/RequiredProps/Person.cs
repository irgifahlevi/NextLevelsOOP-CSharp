using System.Diagnostics.CodeAnalysis;
namespace RequiredProps
{
    public class Person
    {

        #region Constructor
        // Konstruktor default tanpa parameter
        public Person()
        {
            // Tidak melakukan apa-apa pada konstruktor default
        }

        // Konstruktor dengan parameter, menggunakan atribut [SetsRequiredMembers]
        // SetsRequiredMembers menonaktifkan pemeriksaan kompiler bahwa semua anggota yang diperlukan 
        // diinisialisasi ketika sebuah objek dibuat
        [SetsRequiredMembers]
        public Person(int id, string fName, string LName, string dept)
        {
            ID = id;            // Inisialisasi ID
            FirstName = fName;  // Inisialisasi FirstName
            LastName = LName;   // Inisialisasi LastName
            Departement = dept; // Inisialisasi Departement
        }
        #endregion

        #region Method
        // Metode override dari kelas dasar Object untuk memberikan representasi string yang bermakna dari objek Person
        public override string ToString() => $"{FirstName} {LastName}, ID : {ID} in {Departement}";
        #endregion

        #region Property
        public required int ID { get; set; } // Properti ID yang wajib diisi (required)
        public string? FirstName { get; set; } // Properti FirstName yang tidak wajib diisi nullable
        public required string LastName { get; set; } // Properti LastName yang wajib diisi (required)
        public string? Departement { get; set; } // Properti Departement yang tidak wajib diisi nullable
        #endregion
    }
}