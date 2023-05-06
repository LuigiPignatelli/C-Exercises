namespace Polymorphism
{
    internal class Program
    {
        // POLYMORPHISM: invoking derived classes from the same BASE-CLASS during runtime
        static void Main(string[] args)
        {
            // Ferrari and Lambo are both derived from BASE-CLASS Car
            Ferrari ferrariCar = new Ferrari();
            Lambo lamboCar = new Lambo();

            // both Ferrari and Lambo are of type Car and Person accepts a type Car -> Car can have many form
            Person personOne = new Person(lamboCar);
            personOne.Drive();
        }
    }
}