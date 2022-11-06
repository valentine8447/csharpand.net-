
using INTERFACE;

Car car = new Car();
car.Drive();
bool refuel = car.Refuel(50);

if (refuel)
{
    Console.WriteLine("The car was refueld!");
}
car.Drive();