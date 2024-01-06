namespace Challenge
{
    public class Employee
    {
        #region Constructor
        public Employee()
        {

        }
        #endregion
        #region Method
        public virtual void JustPay(int percentage)
        {

        }

        public override string ToString() => $"ID : {ID}, Name : {FullName} in {Departement}";
        #endregion
        #region Property
        public required int ID { get; init; }
        public required string FullName { get; set; }
        public required string Departement { get; set; }
        #endregion
    }
}