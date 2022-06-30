namespace ConsoleApp.OOP
{
    class Boat : Vehicle
    {
        public Boat(string make, string model, string year) : base(make, model, year)
        {
        }

        public bool IsDocked { get; set; }

        public override void Drive()
        {
            if (IsDocked)
            {
                throw new InvalidOperationException("Please undock before to drive");
            }
        }
    }
}
