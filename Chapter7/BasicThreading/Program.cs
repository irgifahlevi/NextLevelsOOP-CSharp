// See https://aka.ms/new-console-template for more information
using BasicThreading;

try
{
    ThreadingSample.MyThread();
}
catch (Exception ex)
{

    throw new Exception("Invalid executing :(", ex);
}
