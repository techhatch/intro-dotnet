namespace ConsoleApp.OOP
{
    #region [ IS-A ]

    class Van : Vehicle
    {
        public Van(string make, string model, string year, Engine engine) : base(make, model, year,engine)
        {

        }

        public override void Drive()
        {

        }
    }
    #endregion
}
