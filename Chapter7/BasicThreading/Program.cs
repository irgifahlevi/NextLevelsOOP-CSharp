// See https://aka.ms/new-console-template for more information
using BasicThreading;

try
{
    // Therading
    ThreadingSample.MyThread();

    // asyncronus 
    await AsyncSample.SampleReadAsync();

    // menggunakan AgregateException dan handler
    await AsyncSample.AsyncHandler();
}
catch (Exception ex)
{

    throw;
}

