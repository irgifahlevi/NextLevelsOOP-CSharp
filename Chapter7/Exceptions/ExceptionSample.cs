using System.Text.Json;

namespace Exceptions
{
    public static class ExceptionSample
    {
        public static void BasicException()
        {

            string wrongPath = "ReadME.JSON";
            string truePath = @"F:\Project\DOTNET\NextLevelsOOP-CSharp\Chapter7\Exceptions\ReadME.JSON";

            // Basic try catch
            string filePath = truePath;
            //System.IO.Stream fileStream = null;
            System.Console.WriteLine($"Current directory : {Directory.GetCurrentDirectory()}");
            try
            {
                /// <summary>
                /// Blok using digunakan untuk mengelola sumber daya, 
                /// seperti membuka file dengan FileStream.
                /// Setelah blok using selesai di eksekusi maka akan secara otomatis menutup sumber daya
                /// </summary>
                /// <param name="fileStream"></param>
                /// <returns></returns>
                using (var fileStream = File.OpenRead(filePath))
                {
                    // Melakukan deserialisasi data dari file JSON ke objek Employee
                    var data = JsonSerializer.Deserialize<Employee>(fileStream);

                    // Menampilkan nama dari objek Employee
                    System.Console.WriteLine($"This name: {data?.FirstName}");
                }

            }
            // Exception spesifik secara umum harus di dahulukan dalam urutan penanganan
            catch (FileNotFoundException)
            {
                System.Console.WriteLine("File not found");
            }
            catch (IOException iox)
            {
                System.Console.WriteLine($"{iox.Message}");
            }
            // menggunakan klausa when 
            catch (JsonException jex)
                when (jex.Message.Contains("converted", StringComparison.OrdinalIgnoreCase) ||
                jex.Message.Contains("invalid after a value", StringComparison.OrdinalIgnoreCase))
            {
                System.Console.WriteLine($"{jex.Message}");
            }
            // Exception reguler biasanya di letakan setelah exception spesifik
            catch (Exception ex)
            {
                // menamplikan pesan error message
                System.Console.WriteLine($"{ex.Message}");
            }
            finally
            {
                // if (fileStream != null)
                // {
                //     // jika filestream tidak kosong 
                //     // Memastikan bahwa fileStream ditutup (dispose) agar tidak ada kebocoran sumber daya
                //     fileStream.Dispose();
                // }
            }
        }

        public static void ThrowExceptions(bool? shouldThrow)
        {
            // jika value = null
            if (!shouldThrow.HasValue)
            {
                throw new ArgumentNullException("Should throw");
            }

            // jika value any
            if (shouldThrow.Value)
            {
                throw new InvalidException("I was told to throw this!");
            }
            else
            {
                System.Console.WriteLine("No exceptions being thrown here");
            }
        }
    }
}