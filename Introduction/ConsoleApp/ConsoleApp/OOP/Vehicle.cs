namespace ConsoleApp.OOP
{
    abstract class Vehicle : IVehicle
    {
        protected Engine? engine;
        protected Vehicle(string make, string model, string year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            //foo();
        }
        protected Vehicle(string make, string model, string year, Engine engine)
            : this(make, model, year)
        {
            this.engine = engine;
        }

        public string Make { set; get; }
        public string Model { set; get; }
        public string Year { set; get; }


        public abstract void Drive();
        
        //private class Hello
        //{
        //    public string Name { set; get; }
        //    private string X { get; set; }
        //    public Hello()
        //    {
        //        Name = String.Empty;
        //    }

        //}

        //void foo()
        //{
        //    Hello hello = new Hello();
        //    hello.Name = "Hello World";
        //}
    }
    
}
