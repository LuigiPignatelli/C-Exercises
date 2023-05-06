namespace DependencyInjection
{
    internal class Program
    {
        // WHY DO WE USE DI?

        static void Main(string[] args)
        {
            // Dependency Injection -> design pattern
            // Dependency Injection -> pass in dependency for our class externally

            // go see the Car class first and then the Person class -> Person class is dependent from Car
            // and Car is instantiated and passed in externally to Person

            Car carDI = new Car(); // Car becomes a dependency for Person -> 1. Instantiate Car, 2. Instantiate Person
            Person personOne = new Person(carDI); // without Car Obj, it is not possible to instatiate a Person Obj
            personOne.Drive(); // the Person obj is dependent on Car obj to be able to drive

            // With DI, objs are given dependency at CREATION TIME ()
            // Dependency are injected into the obj -> Car is the dependency injected into the obj Person
            // we can also ABSTRACT dependency with POLYMORPHISM
        }
    }
}