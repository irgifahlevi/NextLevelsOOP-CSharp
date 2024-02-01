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
    }
}