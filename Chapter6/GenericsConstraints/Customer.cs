namespace GenericsConstraints
{
    public class Customer : IComparable<Customer>
    {
        public int Id { get; set; }
        public DateOnly CreateDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Implements method interface
        public int CompareTo(Customer other)
        {
            if (other.Id == this.Id)
                return 0;
            if (other.Id > this.Id)
                return -1;
            return 1;
        }


        #region Method
        // method type generics

        public T Map<T>(IMapper<Customer, T> mapper)
        {
            // implementasi method dari interface IMapper
            // this merujuk pada instance objek Customer
            return mapper.Map(this);
        }
        #endregion
    }
}