using SingleResponsibilityPrincipalLearning.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrincipalLearning.Business.Car
{
    public class BadCar : IBadCar
    {
        public void ExecuteBadCarImplementation()
        {
            Console.WriteLine("Executing BadCar Implementation...");
            StartEngine();
            Drive();
            PlayMusic();
            OpenTrunk();
            LogTrip();
            Console.WriteLine("BadCar Implementation executed successfully.");
        }
        public void StartEngine()
        {
            Console.WriteLine("Engine started");
        }

        public void Drive()
        {
            Console.WriteLine("Car is moving");
        }

        public void PlayMusic()
        {
            Console.WriteLine("Playing music");
        }

        public void OpenTrunk()
        {
            Console.WriteLine("Trunk opened");
        }

        public void LogTrip()
        {
            Console.WriteLine("Logging trip data to cloud");
        }
    }
}
