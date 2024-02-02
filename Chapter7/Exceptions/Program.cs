// See https://aka.ms/new-console-template for more information
using System.Runtime.Serialization.Formatters.Binary;
using Exceptions;

ExceptionSample.BasicException();

try
{
    ExceptionSample.ThrowExceptions(true);
}
catch (Exception ex)
{
    System.Console.WriteLine(ex);
    throw new InvalidException("This is invalid exceptions", ex);
}
