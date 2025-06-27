using SingleResponsibilityPrincipalLearning.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrincipalLearning.Business.CarProcesses
{
    public class Engine : IEngine
    {
        public Engine() { }
        public void Start()
        {
            Console.WriteLine("Car has started");
        }
        public void TurnOff()
        {
            Console.WriteLine("Car has been turned off");
        }
    }
}
