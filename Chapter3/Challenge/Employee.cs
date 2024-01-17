namespace Challenge
{
    public class Employee
    {
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
        public virtual void AjustPay(decimal percentage)
        {

        }

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

    public class HourlyEmmployee : Employee
    {
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

    public class SalariedEmployee : Employee
    {
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