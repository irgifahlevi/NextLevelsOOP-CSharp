namespace ReadOnlyProps
{
    public class Book
    {
        #region Property
        // private property member kelas
        private readonly string _ISBN = ""; // Variabel hanya bisa diinisialisasi pada saat deklarasi atau dalam konstruktor
        private string _title = "";
        private string _author = "";
        #endregion

        #region Constructor
        // Konstruktor default dengan parameter parameter
        public Book(string ISBN, string Author, string Title)
        {
            // Inisialisasi value
            _ISBN = ISBN;
            _title = Author;
            _author = Title;
        }
        #endregion

        #region Method
        public void Update(string ISBN, string Author, string Title)
        {
            // _ISBN = ISBN; // Tidak dapat mengubah nilai _ISBN karena sudah readonly
            _title = Author;
            _author = Title;
        }

        // Implementasi ulang metode GetAreas dari kelas dasar
        public override string ToString()
        {
            return $"{_ISBN}: {_title} by {_author}";
        }
        #endregion
    }
}