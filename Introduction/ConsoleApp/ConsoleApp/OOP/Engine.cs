namespace ConsoleApp.OOP
{
    class Engine : IEngine
    {
        public bool HasFuel { set; get; }
        public bool HasEngineStarted { get; private set; }
        public float EngineSpeed { get; private set; }

        public void CheckFuel()
        {
            if (!HasFuel)
            {
                throw new InvalidOperationException("You need to refill the fuel tank!");
            }
        }

        public virtual void Accelerate()
        {
            CheckFuel();
            if (HasEngineStarted)
            {
                EngineSpeed++;
            }
        }

        public virtual void Start()
        {
            if (HasEngineStarted) return;
            CheckFuel();
        }
        public virtual void Stop()
        {
            if (HasEngineStarted)
            {
                HasEngineStarted = false;
            }
        }

        public void Decelerate()
        {
            EngineSpeed = EngineSpeed switch
            {
                1 => 0,
                _ when HasEngineStarted => EngineSpeed--,
                _ => 0
            };
        }
    }
}
