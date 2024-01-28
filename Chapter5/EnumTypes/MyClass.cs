namespace EnumTypes
{
    /// <summary>
    /// penggunaan flag (bendera) memungkinkan kombinasi nilai enum menggunakan operasi bitwise. 
    /// Ini berguna ketika ingin mewakili kombinasi beberapa opsi atau atribut dengan
    /// menggunakan satu nilai integral (biasanya integer) sebagai representasinya.
    /// </summary>
    [Flags] // atribut
    public enum ShiftDays : short
    {
        Sunday = 1,
        Monday = 2,
        // Sunday and Monday = 3
        Tuesday = 4,
        Wednesday = 8,
        Thursday = 16,
        Friday = 32,
        Saturday = 64,
        Weekend = 65
    }
    public interface IPerson
    {
        /// <summary>
        /// Interface merupakan blue print yang menyediakan method dan properti tanpa memberikan 
        /// implementasi konkret, yang mengimplementasikan hanyalah kelas kelas yang mengimplementasikan
        /// interface
        /// </summary>
        /// <value></value>
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    /// <summary>
    /// kelas abstrac memungkinka kelas tidak dapat di instance secara langsung, kelas abstrac
    /// merupakan kelas dasar atau blue print
    /// </summary>
    public abstract class Employee : IPerson
    {
        #region Property
        // property implement dari interface Iperson
        public string LastName { get; set; }
        public string FirstName { get; set; }

        // property dari kelas Employee
        public DateOnly StartDate { get; set; }

        // virtual property kelas turunan mendapatkan opsi untuk mengimplementasikan 
        // property DateTime
        public virtual DateTime EndDate { get; set; }

        //abstract property kelas turunan maka kelas turunannya (implementasi konkret) wajib memberikan
        // implementasi untuk property EmployeeId tersebut
        public abstract int EmployeeId { get; }
        #endregion

        // dari kelas turunan wajib mengimplementasikan method ProcessPayroll
        public abstract bool ProcessPayroll();

        // kelas turunan memiliki opsi untuk mengimplementasikan method Terminate
        public virtual void Terminate(DateTime terminationEffectiveDate)
        {
            Console.WriteLine("Employee terminated");
            EndDate = terminationEffectiveDate;
        }

        //derived can call or hide
        public bool IsActive()
        {
            Console.WriteLine("Employee Active");
            DateOnly current = DateOnly.FromDateTime(DateTime.Now);
            return current > StartDate && DateTime.Now < EndDate;
        }
    }

    public class ShiftWorker : Employee
    {
        #region Property
        public TimeOnly ShiftStartTime { get; set; }
        public override int EmployeeId { get => 1; }
        public ShiftDays DaysAvailable { get; set; }
        #endregion

        #region Method

        // Method ProcessParyroll merupakan imploementasi konkret dari base class
        public override bool ProcessPayroll()
        {
            Console.WriteLine("Shiftworker payroll");
            return true;
        }

        // membuat method baru dari base class dengan menggunakan new
        public new bool IsActive()
        {
            Console.WriteLine("Shiftworker active");
            return false;
        }
        #endregion
    }


    public class Manager : Employee, IPerson
    {

        #region Property
        // property dari kelas manager
        public int NumberOfDirectReports { get; set; }

        // overide property dari kelas dasar yang harus di implementasikan secara konkret
        public override int EmployeeId { get => new System.Random().Next(1, 100); }
        #endregion

        #region Method
        // Method abstract harus di implementasikan secara konkret, dari kelas dasar
        public override bool ProcessPayroll()
        {
            Console.WriteLine("Manager payroll");
            return true;
        }

        // implementasi method virtual dengan memberikan opsi kepada kelas trurunan
        public override void Terminate(DateTime terminationEffectiveDate)
        {
            //perform manager specific termination steps
            Console.WriteLine("Manager terminated");

            // opsional memanggil method terminate dari base class 
            base.Terminate(terminationEffectiveDate);
        }
        #endregion

    }
}