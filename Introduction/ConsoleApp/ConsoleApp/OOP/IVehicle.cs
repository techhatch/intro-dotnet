namespace ConsoleApp.OOP
{
    internal interface IVehicle
    {
        string Make { get; set; }
        string Model { get; set; }
        string Year { get; set; }

        void Drive();
    }
    interface IVehicleWithEngine : IVehicle
    {
        Engine Engine { get;  }
    }
}