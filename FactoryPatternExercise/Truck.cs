using System;
namespace FactoryPatternExercise
{
    public class Truck : IVehicle  // These 2 classes must implement the Drive method
    {
        public Truck()
        {
        }

        public void Drive()
        {
            Console.WriteLine("This Truck is drivable.");
        }
    }
}

