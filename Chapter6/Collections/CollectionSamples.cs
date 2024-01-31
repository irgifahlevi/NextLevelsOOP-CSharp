namespace Collections
{
    public static class CollectionSamples
    {
        /// <summary>
        /// FIFO (First-In-First-Out): Elemen yang pertama dimasukkan ke dalam Queue akan menjadi 
        /// elemen pertama yang dikeluarkan (seperti antrian di kasir).
        /// </summary>
        // Metode untuk mendemonstrasikan penggunaan Queue
        public static void Queue(string a, string b, string c)
        {
            // Membuat objek Queue dari System.Collections
            var q = new System.Collections.Queue();

            // Menambahkan elemen ke dalam Queue
            q.Enqueue(a);
            q.Enqueue(b);
            q.Enqueue(c);


            string? item = null;

            // Menampilkan pesan untuk Queue
            Console.WriteLine("Using a Queue");

            // q.Dequeue(): Metode ini menghapus dan mengembalikan elemen pertama dari Queue.
            // (string?): Operator cast ini digunakan untuk mencoba mengonversi hasil q.Dequeue()
            // hasil cast di simpan ke dalam item
            // Looping untuk mengambil dan menampilkan elemen dari Queue
            while ((item = (string?)q.Dequeue()) != null)
            {
                Console.WriteLine(item);

                // Break dari loop jika Queue sudah kosong
                if (q.Count <= 0)
                    break;
            }
        }

        /// <summary>
        /// LIFO (Last-In-First-Out): Elemen yang terakhir dimasukkan ke dalam Stack akan menjadi 
        /// elemen pertama yang dikeluarkan (seperti tumpukan buku).
        /// </summary>
        // method untuk mendemonstrasikan penggunaan Stack
        public static void Stack(string a, string b, string c)
        {
            // Membuat objek Stack dari System.Collections.Stack();
            var stk = new System.Collections.Stack();

            // Menambahkan elemen ke dalam Stack
            stk.Push(a);
            stk.Push(b);
            stk.Push(c);

            string? stkItem = null;

            Console.WriteLine();
            Console.WriteLine("Using a stack");

            // stk.Pop(): Metode ini menghapus dan mengembalikan elemen terakhir dari Stack.
            // (string?): Operator cast ini digunakan untuk mencoba mengonversi hasil stk.Pop()
            // hasil cast di simpan ke dalam stkItem
            // Looping untuk mengambil dan menampilkan elemen dari Stack
            while ((stkItem = (string?)stk.Pop()) != null)
            {
                Console.WriteLine(stkItem);

                // Break dari loop jika Stack sudah kosong
                if (stk.Count <= 0)
                    break;
            }
        }

        // Stack generic
        public static void StackGeneric(string a, string b, string c, string d)
        {
            // Membuat objek Stack dari System.Collections.Stack();
            var stk = new System.Collections.Generic.Stack<string>();

            // Menambahkan elemen ke dalam Stack
            stk.Push(a);
            stk.Push(b);
            stk.Push(c);
            stk.Push(d);

            string? stkItem = null;

            Console.WriteLine();
            Console.WriteLine("Using a stack generic");

            // stk.Pop(): Metode ini menghapus dan mengembalikan elemen terakhir dari Stack.
            // (string?): Operator cast ini digunakan untuk mencoba mengonversi hasil stk.Pop()
            // hasil cast di simpan ke dalam stkItem
            // Looping untuk mengambil dan menampilkan elemen dari Stack
            while ((stkItem = stk.Pop()) != null)
            {
                Console.WriteLine(stkItem);

                // Break dari loop jika Stack sudah kosong
                if (stk.Count <= 0)
                    break;
            }
        }
    }

    public class CustomStack<T> : Stack<T>
    {
        public void MyPush(ICollection<T> collection)
        {
            Console.WriteLine();
            System.Console.WriteLine("Using Collection Stack");
            foreach (var items in collection)
            {
                base.Push(items);
            }
        }

        public void MyPop()
        {
            System.Console.WriteLine(base.Pop());
        }
    }
}