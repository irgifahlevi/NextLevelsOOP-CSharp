namespace MethodExtensions
{
    public static class StringExtensionsSample
    {
        // Extension method Right digunakan untuk mengambil sejumlah karakter terakhir dari sebuah string.
        // Misalnya: "Hello, World!".Right(5) akan mengembalikan "World!".
        // Jika input string kosong atau null, metode ini mengembalikan string kosong.
        // Dengan menambahkan this string, kita memberi tahu C# bahwa metode Right adalah ekstensi khusus untuk tipe data string. 
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
    }
}