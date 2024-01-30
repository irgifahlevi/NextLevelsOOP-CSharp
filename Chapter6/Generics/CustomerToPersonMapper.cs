namespace Generics
{
    /// <summary>
    /// CustomerToPersonMapper merupakan class yg mengimplementasikan interface IMapper
    /// </summary>
    /// <param name="Customer">Sumber atau asal dari data yang akan dipetakan.</param>
    /// <param name="Person">Destinasi atau tempat data akan dipetakan.</param>
    public class CustomerToPersonMapper : IMapper<Customer, Person>
    {

        /// <summary>
        /// Implementasi method dari interface
        /// </summary>
        /// <param name="Map"></param>
        /// <returns></returns>
        public Person Map(Customer source)
        {
            return new Person
            {
                Id = source.Id,
                FirstName = source.FirstName,
                LastName = source.LastName
            };
        }

    }
}