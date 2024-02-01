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
            System.IO.Stream fileStream = null;
            System.Console.WriteLine($"Current directory : {Directory.GetCurrentDirectory()}");
            try
            {
                fileStream = File.OpenRead(filePath);

                // Melakukan deserialisasi data dari file JSON ke objek Employee
                var data = JsonSerializer.Deserialize<Employee>(fileStream);

                // Menampilkan nama dari objek Employee
                System.Console.WriteLine($"This name: {data?.FirstName}");
            }
            catch (Exception ex)
            {
                // menamplikan pesan error message
                System.Console.WriteLine($"{ex.Message}");
            }
            finally
            {
                if (fileStream != null)
                {
                    // jika filestream tidak kosong 
                    // Memastikan bahwa fileStream ditutup (dispose) agar tidak ada kebocoran sumber daya
                    fileStream.Dispose();
                }
            }
        }
    }
}