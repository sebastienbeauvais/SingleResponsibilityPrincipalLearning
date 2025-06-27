using SingleResponsibilityPrincipalLearning.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrincipalLearning.Business.CarProcesses
{
    public class Trunk : ITrunk
    {
        public Trunk() { }
        public void Open()
        {
            Console.WriteLine("Trunk opened");
        }
        public void Close()
        {
            Console.WriteLine("Trunk closed");
        }
    }
}
