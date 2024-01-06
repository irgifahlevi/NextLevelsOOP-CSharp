namespace Challenge
{
    public class Salaries : Employee
    {
        #region Constructor
        public Salaries()
        {

        }
        #endregion

        #region Method
        public override void JustPay(int percentage)
        {
            Salary += (Salary * percentage);
        }
        #endregion

        #region Property
        public int Salary { get; set; }
        #endregion
    }
}