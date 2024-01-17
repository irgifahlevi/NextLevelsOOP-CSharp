namespace Challenge
{
    public abstract class Employee
    {
        /// <summary>
        /// Kelas abstrac kelas yang tidak dapat diinstansiasi (dibuat objeknya) secara langsung
        /// kelas abstract digunakan sebagai kerangka dasar untuk kelas-kelas turunannya.
        /// </summary>
        /// <returns></returns>
        /// 
        #region Members
        private static int _empCount = 0;
        protected static int IDStart;
        #endregion

        #region Constructor
        // static constructor (first called)
        static Employee()
        {
            IDStart = 1000;
        }

        // reguler constructor
        public Employee()
        {
            _empCount++;   // Menambahkan satu ke variabel statis _empCount untuk melacak jumlah total karyawan.
            ID = IDStart++; // Menginisialisasi ID karyawan menggunakan nilai IDStart dan kemudian meningkatkan IDStart.
        }
        #endregion


        #region Methods
        public abstract void AjustPay(decimal percentage);

        public override string ToString() => $"{ID}: {FullName}, {Department}";
        #endregion

        #region Members
        public static int EmployeeCount { get => _empCount; }

        // Properti ID karyawan yang diinisialisasi saat objek dibuat
        public int ID { get; init; }
        public required string Department { get; set; }
        public required string FullName { get; set; }
        #endregion
    }

    public sealed class HourlyEmmployee : Employee
    {
        /// <summary>
        /// sealed digunakan dalam C# untuk mengonfirmasi bahwa suatu kelas atau metode 
        /// tidak dapat diwariskan atau di-override
        /// </summary>
        /// 
        #region Constructor
        public HourlyEmmployee()
        {

        }
        #endregion

        #region Members Property
        public decimal PayRate { get; set; }
        #endregion

        #region Method

        // method yang di wariskan dari base class
        public override void AjustPay(decimal percentage)
        {
            PayRate += (PayRate * percentage);
        }
        #endregion
    }

    public sealed class SalariedEmployee : Employee
    {
        /// <summary>
        /// sealed digunakan dalam C# untuk mengonfirmasi bahwa suatu kelas atau metode 
        /// tidak dapat diwariskan atau di-override
        /// </summary>

        #region Constructor
        public SalariedEmployee()
        {

        }
        #endregion

        #region Members Property
        public decimal Sallary { get; set; }
        #endregion

        #region Method

        // method yang di wariskan dari base class
        public override void AjustPay(decimal percentage)
        {
            Sallary += (Sallary * percentage);
        }
        #endregion
    }
}