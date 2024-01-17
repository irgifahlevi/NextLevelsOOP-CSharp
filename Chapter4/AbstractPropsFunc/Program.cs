// See https://aka.ms/new-console-template for more information
// instance the class Car & Motorcycle
using AbstractPropsFunc;
Car cars = new Car() { Make = "Ferari", Model = "Escort" };
Motorcycle motor = new Motorcycle() { Make = "Trumph", Model = "Thunder" };

Console.WriteLine($"{cars}");
cars.SoundHorn();
Console.WriteLine($"{motor}");
motor.SoundHorn();

// abstract class tidak bisa di instance
// Vehicle vehicle = new Vehicle();