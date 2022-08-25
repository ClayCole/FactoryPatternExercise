using System;
namespace FactoryPatternExercise
{
    public class Car : IVehicle  //These 2 classes must implement the Drive method
    {
        public Car()
        {
            
        }

        public void Drive()
        {
            Console.WriteLine("This Car is drivable"); ;
        }
    }
}

