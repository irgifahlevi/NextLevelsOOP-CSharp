namespace Generics
{
    public class Customer
    {
        public int Id { get; set; }
        public DateOnly CreateDate { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }


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