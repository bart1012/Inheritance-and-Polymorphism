namespace Inheritance_and_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> myVehicles = new List<Vehicle>() { new Car("Renault", "Clio", 90, FuelType.Diesel), new Motorcycle("Honda", "Rebel", false, 70, FuelType.Unleaded) };
            myVehicles.ForEach(vehicle => { vehicle.StartEngine(); vehicle.Drive(); });             
        }
    }
}
