namespace Challenge
{
    public class Hours : Employee
    {
        #region Constructor
        public Hours()
        {

        }
        #endregion

        #region Method
        public override void JustPay(int percentage)
        {
            PayRate += (PayRate * percentage);
        }
        #endregion

        #region Property
        public int PayRate { get; set; }
        #endregion

    }
}