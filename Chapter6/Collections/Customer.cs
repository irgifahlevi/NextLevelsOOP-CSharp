namespace Collections
{
    public class Customer : IComparable<Customer>
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }

        public int CompareTo(Customer? other)
        {
            return this.Id.CompareTo(other?.Id);
        }

    }
}