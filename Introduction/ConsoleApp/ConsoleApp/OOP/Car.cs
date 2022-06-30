namespace ConsoleApp.OOP
{
    #region [ IS-A ]

    class Car : Vehicle, IVehicleWithEngine
    {
        public Car(string make, string model, string year, Engine engine, Func<(int count, int size, int airPresure)> createWheelParams , int doors)
            : base(make, model, year, engine)
        {
            var  (count, size, airPresure)  = createWheelParams();
            Wheels = Enumerable.Range(0, count)
                .Select(idx =>
                   new Wheel(
                       idx,
                       size,
                       new Tyre(airPresure),
                       new { Size = $"{size}\"" }
                       )).ToList();

            Doors = Enumerable.Range(1, doors).Select(idx => new Door { Id = idx }).ToList();
        }

        public Engine Engine => engine!;
        public IReadOnlyCollection<Wheel> Wheels { get; protected set; }
        public IReadOnlyCollection<Door> Doors { get; }

        public override void Drive()
        {

        }
        public override string ToString()
        {
            return $"Make :{Make}, Model: {Model}, Year: {Year}";
        }
    }
    #endregion
}
