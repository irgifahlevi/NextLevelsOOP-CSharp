namespace MethodExtensions
{
    public static class StringExtensionsSample
    {
        // Extension method Right digunakan untuk mengambil sejumlah karakter terakhir dari sebuah string.
        // Misalnya: "Hello, World!".Right(5) akan mengembalikan "World!".
        // Jika input string kosong atau null, metode ini mengembalikan string kosong.
        // Dengan menambahkan this string, kita memberi tahu C# bahwa metode Right adalah ekstensi khusus untuk tipe data string. 
        // namun dengan catatan class harus d buat static
        public static string Right(this string input, int numChars)
        {
            // Memeriksa apakah input string null atau kosong.
            if (string.IsNullOrEmpty(input))
            {
                // Jika iya, kembalikan string kosong.
                return string.Empty;
            }

            // Memeriksa apakah panjang input string lebih dari numChars.
            if (input.Length < numChars)
            {
                return input;
            }

            // Menggunakan Substring untuk mengambil sejumlah karakter terakhir.
            return input.Substring(input.Length - numChars);
        }


        // Chalenge
        public static double Median(this int[] numbers)
        {
            // menyalin array dengan casting operator
            int[] cNumbers = (int[])numbers.Clone();

            // mengurutkan array secara ascending
            Array.Sort(numbers);

            // hitung jumlah array
            int size = numbers.Count();

            // menghitung index tengah array
            int mid = size / 2;

            // menghitung nilai median

            /// <summary>
            /// Jika jumlah elemen array ganjil, maka nilai median adalah elemen di tengah array. 
            /// Jika jumlah elemen array genap, maka nilai median adalah rata-rata dari dua elemen
            /// di tengah array.
            /// </summary>

            double median = (size % 2 != 0) ? (double)cNumbers[mid] : ((double)cNumbers[mid] + (double)cNumbers[mid - 1]) / 2;
            return median;
        }
    }
}