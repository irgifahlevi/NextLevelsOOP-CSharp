namespace Generics
{
    /// <summary>
    /// Merupakan interface 
    /// </summary>
    /// <typeparam name="S">Parameter merujuk pada tipe data sumber atau asal dari data yang akan dipetakan.</typeparam>
    /// <typeparam name="T">Parameter merujuk pada tipe data destinasi atau tempat data akan dipetakan.</typeparam>
    public interface IMapper<S, T>
    {
        T Map(S source);
    }
}