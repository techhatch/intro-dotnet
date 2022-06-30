namespace ConsoleApp.OOP
{
    class MotorBoat : Boat, IVehicleWithEngine
    {
        public MotorBoat(string make, string model, string year, Engine engine) : base(make, model, year)
        {
            base.engine = engine;
        }

        public Engine Engine => engine!;
    }
}
