using System;

namespace AbstractClasses
{
    // ABSTRACT CLASSES -> use "abstract"
    // Why do we need abstract classes? 1. shared functionality, 2. we don't know how they should be defined
    // EACH CLASS deriving from the Abstract Class should have THEIR OWN IMPLEMENTATION
    // IMPORTANT: we cannot instantiacate AC

    // In Ferrari and Lambo classes we have duplicated code -> use an abstract class
    internal class Program
    {
        static void Main(string[] args)
        {
            // Car is the base class for Ferrari and Lambo -> we can also sat this "Car ferrariCar = new Ferrari();"
            Ferrari ferrariCar = new Ferrari(); 
            Lambo lamboCar = new Lambo();

            Person personOne = new Person(ferrariCar);
            ferrariCar.TurnOnOff(); // even though TurnOnOff() is not defined in Ferrari, it's inherited
            personOne.Drive();
        }
    }
}