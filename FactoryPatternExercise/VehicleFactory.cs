using System;
namespace FactoryPatternExercise
{
    public static class VehicleFactory   // Create a static VehicleFactory class:
    {
        public static IVehicle GetVehicel(int wheelCount)  //Add a GetVehicle method that will return an IVehicle based on the amount of tires it’s given as a parameter:
        {            // ^^ return type is IVehicle 

            switch (wheelCount)
            {
             
                case 4:
                    return new Car();
                case 6:
                    return new Truck();
                case 8:
                    return new Truck();
                default:
                    return new Car();
                 
            }
        }

        
    }
}

