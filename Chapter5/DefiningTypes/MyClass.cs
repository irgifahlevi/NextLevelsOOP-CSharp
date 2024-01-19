namespace DefiningTypes
{
    /// <summary>
    /// Interface untuk mendefinisikan properti umum
    /// </summary>
    public interface IPerson
    {
        #region Property
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public Age Age { get; set; }
        #endregion
    }

    /// <summary>
    /// Class employee yang mengimplementasikan interface IPerson
    /// </summary>
    public class Employee : IPerson
    {
        #region Constructor
        /// <summary>
        /// apabila base class menggunakan constructor dengan parameter maka subclass harus menggunakan 
        /// constructor dangan parameter
        /// </summary>
        public Employee()
        {

        }
        public Employee(string fName, string lName, int id = 0)
        {
            FirstName = fName;
            LastName = lName;
            Id = id;
        }
        #endregion


        #region Interface Property
        // Implementasi properti dari kelas person
        public string LastName { get; set; }
        public int Id { get; set; }
        public Age Age { get; set; }
        public string FirstName { get; set; }
        #endregion

        #region Employee Property
        // class employee properti
        public int EmployeeId { get; set; }
        public DateOnly StartDate { get; set; }
        public TimeOnly ShiftStartTime { get; set; }
        #endregion
    }

    public class Manager : Employee, IPerson
    {
        /// <summary>
        /// Ketika kelas manager mewariskan dari kelas Emmploye maka tidak perlu mengimplementasikan
        /// ulang interface Iperson
        /// </summary>

        #region Constructor
        // mengimplementasikan constructor dari base class
        public Manager(string firstName, string lastName) : base(firstName, lastName)
        {

        }
        #endregion

        #region Property
        public int NumberOfDirectReports { get; set; }
        #endregion

        #region Method
        public override string ToString() => $" Hello my name is {base.FirstName} {base.LastName}";
        #endregion
    }

    //structs - value types
    public struct Age
    {
        public DateTime BirthDate { get; set; }
        public int YearsOld { get; set; }
    }

    public struct VendorContact : IPerson
    {
        public string LastName { get; set; }
        public int Id { get; set; }
        public Age Age { get; set; }
        public string FirstName { get; set; }
    }

    //records (C# 9)
    public record Customer : IPerson
    {
        public string LastName { get; set; }
        public int Id { get; set; }
        public Age Age { get; set; }
        public string FirstName { get; set; }
    }

    public record PremiereCustomer : Customer
    {
        public byte CustomerLevel { get; init; }
    }

    //record structs (C# 10)
    public record struct Order
    {
        public int OrderId { get; set; }
        public DateOnly OrderDate { get; set; }

    }
    public record struct RecurringOrder
    {

    }

}