// See https://aka.ms/new-console-template for more information
using BasicThreading;

try
{
    ThreadingSample.MyThread();

    // asyncronus 
    await AsyncSample.SampleReadAsync();
}
catch (Exception ex)
{

    throw new Exception("Invalid executing :(", ex);
}
