using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.OOP
{
    public interface IEngine
    {
        bool HasFuel { get; set; }
        bool HasEngineStarted { get; }
        float EngineSpeed { get; }
        void Accelerate();
        void Decelerate();
        void Start();
        void Stop();
    }
}
