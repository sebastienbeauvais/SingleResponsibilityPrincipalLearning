using SingleResponsibilityPrincipalLearning.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrincipalLearning.Business.CarProcesses
{
    public class TripLogger : ITripLogger
    {
        private double distance = 0.0;
        private string destination = "San Diego";
        public TripLogger() { }
        public void LogTrip(/* this would be ITripDetails Later*/)
        {
            var distance = 121.4;
            var destination = "Los Angeles";

            Console.WriteLine($"Trip logged: {distance} miles to {destination}");
        }
    }
}
