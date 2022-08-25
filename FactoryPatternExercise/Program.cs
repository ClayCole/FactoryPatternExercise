// See https://aka.ms/new-console-template for more information
using FactoryPatternExercise;

int wheelCount;
bool input = false;

do
{
    Console.WriteLine("Please Enter the amount of tires for the vehicle you wish to create");

    input = int.TryParse(Console.ReadLine(), out wheelCount);

   

} while (input == false);

    var vehicle = VehicleFactory.GetVehicel(wheelCount);
vehicle.Drive();

Console.ReadLine();