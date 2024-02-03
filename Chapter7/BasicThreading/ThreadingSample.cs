using System.Text.Json;

namespace BasicThreading
{
    public static class ThreadingSample
    {
        public static void MyThread()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            System.Console.WriteLine($"Main thread id : {Thread.CurrentThread.ManagedThreadId}");
            Console.ResetColor();

            Thread t = new Thread(Reading);

            t.Start();
            t.Join();
            System.Console.WriteLine("Work happening in main thread :D");

            System.Console.WriteLine("After all done");
        }

        private static void Reading()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            System.Console.WriteLine($"File access thread id : {Thread.CurrentThread.ManagedThreadId}");
            Console.ResetColor();

            string truePath = @"F:\Project\DOTNET\NextLevelsOOP-CSharp\Chapter7\BasicThreading\jennifer.JSON";

            try
            {
                using (var fileStream = File.OpenRead(truePath))
                {
                    var data = JsonSerializer.Deserialize<Employee>(fileStream);
                    if (data != null)
                    {
                        System.Console.WriteLine($"Employee read from file : {data.Id} {data.FirstName}");
                    }
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