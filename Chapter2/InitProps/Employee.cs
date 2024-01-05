namespace InitProps
{
    public class Employee
    {
        // Properti _id sebagai ID karyawan (readonly tidak dapat diubah setelah diinisialisasi)
        private readonly int _id;

        #region Constructor


        public Employee()
        {
            // Konstruktor default tidak melakukan apa-apa (tidak menginisialisasi _id)
        }

        // Konstruktor dengan parameter untuk membuat objek Employee dengan nilai awal
        public Employee(int id, string fName, string lName, string departement)
        {
            ID = id;                // Inisialisasi ID menggunakan properti ID (memanfaatkan init dalam properti)
            FirstName = fName;      // Inisialisasi FirstName
            LastName = lName;       // Inisialisasi LastName
            Departement = departement;  // Inisialisasi Departement
        }
        #endregion

        #region Method

        // Metode override dari kelas dasar Object untuk memberikan representasi string dari objek Employee
        public override string ToString() => $"{FirstName}{LastName}, ID:{ID}, {Departement}";

        #endregion

        #region Property
        public int ID
        {
            // Properti ID dengan lambda expression untuk mendapatkan nilai _id
            get => _id;
            // Properti ID dengan lambda expression untuk menginisialisasi nilai _id
            // Dengan menggunakan init, Anda dapat menginisialisasi nilai _id hanya 
            // pada saat pembuatan objek Employee. Setelah objek dibuat, 
            // nilai properti ID tidak dapat diubah lagi.
            init => _id = value;
        }

        // Properti FirstName dengan kemungkinan nilai null (?)
        public string? FirstName { get; set; }

        // Properti LastName dengan kemungkinan nilai null (?)
        public string? LastName { get; set; }

        // Properti Departement dengan kemungkinan nilai null (?)
        public string? Departement { get; set; }
        #endregion
    }
}