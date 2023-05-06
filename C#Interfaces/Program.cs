namespace C_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instantiate classes that use the same interface
            Ferrari ferrariCar = new Ferrari();
            Lambo lamboCar = new Lambo();

            // our dependency is not just a class anymore, but a interface (any class that implements the set of function members)
            // ICar means that we do not know what type of car that is, as long as it implements the function members
            Person personOne = new Person(lamboCar); // thanks to DI, the person OBJ now accepts every class from the Interface
            personOne.Drive();
        }
    }
}