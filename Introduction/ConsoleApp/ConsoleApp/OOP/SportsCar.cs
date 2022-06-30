namespace ConsoleApp.OOP
{
    #region [ IS-A ]
    class SportsCar : Car
    {
        public SportsCar(string make, string model, string year, Engine engine) : base(make, model, year, engine, () => (4, 17, 30), 4)
        {
        }
    }
    #endregion
}
