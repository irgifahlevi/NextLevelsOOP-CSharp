using System.Text.Json;

namespace BasicThreading
{
    public static class AsyncSample
    {
        /// <summary>
        /// ketika menggunakan operasi asinkron (async/await), eksekusi program tidak akan diblokir 
        /// oleh operasi yang memakan waktu, seperti pembacaan berkas atau panggilan jaringan.
        /// </summary>
        public static async Task SampleReadAsync()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine($"Main thread id form async : {Thread.CurrentThread.ManagedThreadId}");
            Console.ResetColor();

            // method ini dilakukan secara asinkron, yang berarti tidak akan memblokir eksekusi program.
            // await digunakan untuk menunggu hasil dari operasi asinkron sebelum melanjutkan eksekusi kode selanjutnya.
            // await memastikan bahwa program akan menunggu hingga berkas selesai dibaca sebelum melanjutkan ke baris kode selanjutnya. 
            //await ReadAsync("jennifer");

            // Membuat objek Task untuk membaca file "jennifer" secara asinkron
            Task tJennifer = ReadAsync("jennifer");

            // Membuat objek Task untuk membaca file "lucas" secara asinkron
            Task tLucas = ReadAsync("lucas");

            System.Console.WriteLine($"Work happening in main async :D");

            // Menunggu kedua Task selesai sebelum melanjutkan eksekusi
            await Task.WhenAll(tJennifer, tLucas);

        }


        private static async Task ReadAsync(string employee)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine($"File acccess thread id from async : {Thread.CurrentThread.ManagedThreadId}");
            Console.ResetColor();

            // Menyusun path lengkap dengan menggunakan Path.Combine
            string truePath = Path.Combine(@"F:\Project\DOTNET\NextLevelsOOP-CSharp\Chapter7\BasicThreading\", $"{employee}.JSON");
            try
            {
                // method ini Operasi ini dilakukan secara asinkron, yang berarti tidak akan memblokir eksekusi program.
                // await digunakan untuk menunggu hasil dari operasi asinkron sebelum melanjutkan eksekusi kode selanjutnya.
                // await memastikan bahwa program akan menunggu hingga berkas selesai dibaca sebelum melanjutkan ke baris kode selanjutnya. 
                var fileStream = await File.ReadAllTextAsync(truePath);
                var data = JsonSerializer.Deserialize<Employee>(fileStream);
                if (data != null)
                {
                    System.Console.WriteLine($"Employee read from file : {data.Id} {data.FirstName}");
                }
            }
            catch (FileNotFoundException fex)
            {
                // Menambahkan informasi spesifik untuk FileNotFoundException
                throw new ArgumentException("This file not found", fex);
            }
            catch (IOException iox)
            {
                throw new ArgumentException("This file not found", iox);
            }
            catch (JsonException je)
            {
                // Menambahkan informasi spesifik untuk JsonException
                throw new ArgumentException("Invalid deserialize json object", je);
            }
            catch (Exception ex)
            {
                // Menambahkan informasi spesifik untuk Exception umum
                throw new ArgumentException(ex.Message, ex);
            }
        }
    }
}