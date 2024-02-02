using System.Runtime.Serialization;

namespace Exceptions
{
    /// <summary>
    /// Atribut [Serializable] pada kelas exception menandakan bahwa kelas tersebut dapat 
    /// di-serialize, yaitu dapat dikonversi menjadi bentuk yang dapat diambil dan
    /// diubah menjadi byte stream
    /// </summary>
    // Menandakan bahwa kelas ini dapat diserialisasi.
    [Serializable]
    public class InvalidException : Exception
    {
        // Constructor tanpa parameter untuk membuat pengecualian tanpa pesan.
        public InvalidException() : base()
        { }

        // Constructor dengan parameter pesan untuk membuat pengecualian dengan pesan tertentu.
        public InvalidException(string message) : base(message)
        { }

        // Constructor dengan parameter pesan dan innerException untuk membuat pengecualian
        // dengan pesan tertentu dan menetapkan pengecualian internal.
        public InvalidException(string message, Exception innerException) : base(message, innerException)
        { }

        // Constructor yang digunakan saat melakukan deserialisasi.
        protected InvalidException(SerializationInfo info, StreamingContext context) : base(info, context)
        { }
    }
}