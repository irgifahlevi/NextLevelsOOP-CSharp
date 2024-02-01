using System.Collections.Concurrent;
using System.Collections.Specialized;

namespace Collections
{
    public static class MyCollections
    {
        private static List<Customer> customers;

        // Static constructor
        static MyCollections()
        {
            customers = new List<Customer>();
            for (int i = 1; i < 11; i++)
            {
                customers.Add(new Customer { Id = i, FirstName = i.ToString(), LastName = "Customer", Age = 20 + i });
            }
        }

        // methods
        public static void Indexing()
        {
            // mengambil list customer ke 3
            var customersTheree = customers[2];
            System.Console.WriteLine($"Customer found {customersTheree.Id} at index [2]");

            // cek apakah collection mengandung index
            var doesContain = customers.Contains(customersTheree) ? "Does" : "Does't";
            System.Console.WriteLine($"Customers {doesContain} contain is customer");

            var newCustomersTheree = customers[2];
            if (customersTheree == newCustomersTheree)
            {
                System.Console.WriteLine("Same");
            }
            else
            {
                System.Console.WriteLine("Not same");
            }

            // mencari customer dengan find
            var findCustomer = customers.Find(CustomerIsMatch);

            if (findCustomer != null)
            {
                // Jika custommer tidak kosong maka cetak ID costummer
                Console.WriteLine($"Found customer {findCustomer.Id}");
            }
            else
            {
                Console.WriteLine("No customer found with that ID.");
            }

        }

        private static bool CustomerIsMatch(Customer c)
        {
            return c.Id == 7;
            //FOLLOW UP: What happens if your expression matches more than one item?
        }

        public static void Iterating()
        {
            // Membalik urutan elemen dalam daftar
            customers.Reverse();

            // Menggunakan IEnumerator untuk iterasi melalui list
            IEnumerator<Customer> custEnum = customers.GetEnumerator();
            while (custEnum.MoveNext())
            {
                Customer current = custEnum.Current;
                Console.WriteLine($"{current.FirstName} {current.LastName}");
            }

            // Mengurutkan daftar pelanggan
            customers.Sort();  // atau dalam kasus ini, Reverse akan memberikan efek yang sama

            // Atau menggunakan foreach
            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.FirstName} {customer.LastName}");
            }
        }

        public static void Dictionary()
        {
            /// <summary>
            /// Kegunaan utama dari Dictionary adalah untuk menyimpan kumpulan data dalam bentuk pasangan 
            /// kunci-nilai (key-value pairs), di mana setiap elemen memiliki kunci yang bersifat unik
            /// dan nilai yang terkait. 
            /// </summary>
            /// <typeparam name="string">Digunakan sebagai key</typeparam>
            /// <typeparam name="Person">Digunakan sebagai values yang terkait dengan keynya</typeparam>
            /// <returns></returns>
            Dictionary<string, Person> person = new Dictionary<string, Person>();

            // m merupakan key
            // new Person {} merupakan valuesnya
            person.Add("m", new Person { Id = 1, FirstName = "Max", LastName = "Carl", Age = 23, Address = "USA" });
            person.Add("j", new Person { Id = 2, FirstName = "Jhef", LastName = "Jedy", Age = 33, Address = "USA" });
            person.Add("a", new Person { Id = 3, FirstName = "Andy", LastName = "Lastrada", Age = 25, Address = "USA" });

            // TryAdd merupakan method untuk menambahkan elemen ke dalam dictionary
            // apabila key sudah ada tidak akan mengembalikan error
            person.TryAdd("m", new Person { Id = 4, FirstName = "Mia", LastName = "Gane", Age = 23, Address = "UAE" });
            // cek key
            bool keyCheck = person.ContainsKey("m");
            if (person.ContainsKey("m"))
            {
                // akses nilai yang terkait dengan kunci tersebut dengan menggunakan person["m"]
                var p = person["m"];

                // ceta property person
                System.Console.WriteLine($"Person with key m {p.FirstName}{p.LastName} Id = {p.Id}");
            }

            // deklarasi person1 dengan tipe data person
            Person? person1;

            // TryGetValue: Memanggil metode TryGetValue pada dictionary person. 
            // Metode ini berusaha untuk mendapatkan nilai yang terkait dengan kunci "m". 
            // out (person1) akan di isi dengan nilai yang terkait dengan kunci "m"
            if (person.TryGetValue("m", out person1))
            {
                System.Console.WriteLine($"TryGetValue method is returned {person1.FirstName}");
            }

            foreach (var item in person)
            {
                System.Console.WriteLine($"Item Key {item.Key}\t Item value : {item.Value.FirstName}");
            }
        }

        public static void NameValue()
        {
            /// <summary>
            /// NameValueCollection untuk menyimpan pasangan nama-nilai (name-value pairs)
            ///  dan kemudian mencetak nilai-nilai dengan mengaksesnya menggunakan kunci.
            /// </summary>
            /// <returns></returns>
            var items = new NameValueCollection();

            // menambahkan pasangan nama-nilai ke dalam koleksi "m" & "Max"
            items.Add("m", "Max");
            items.Add("j", "Joe");

            // AllKeys memberikan array dari semua kunci yang terkandung dalam NameValueCollection.
            foreach (var item in items.AllKeys)
            {
                System.Console.WriteLine(items[item]);
            }
        }

        public static void Concurrent()
        {
            var bag = new ConcurrentBag<Person>();

            bag.Add(new Person { Id = 1, FirstName = "Jack", LastName = "Miller", Age = 34 });
            bag.Add(new Person { Id = 2, FirstName = "Mawi", LastName = "Are", Age = 34 });
            bag.Add(new Person { Id = 3, FirstName = "Claude", LastName = "Khalifa", Age = 34 });
            bag.Add(new Person { Id = 4, FirstName = "Danils" });

            foreach (var items in bag)
            {
                System.Console.WriteLine($"Concurrent {items.FirstName}{items.LastName}");
            }
        }

    }
}