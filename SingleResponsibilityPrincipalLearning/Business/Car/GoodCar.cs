using SingleResponsibilityPrincipalLearning.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrincipalLearning.Business.Car
{
    public class GoodCar
    {
        private readonly IEngine _engine;
        private readonly IMusicSystem _musicSystem;
        private readonly ITrunk _trunk;
        private readonly ITripLogger _tripLogger;
        public GoodCar(IEngine engine, IMusicSystem musicSystem, ITrunk trunk, ITripLogger tripLogger)
        {
            _engine = engine;
            _musicSystem = musicSystem;
            _trunk = trunk;
            _tripLogger = tripLogger;
        }
        public void ExecuteGoodCarImplementation()
        {
            Console.WriteLine("Executing GoodCar Implementation...");
            Drive();
            PlayMusic();
            OpenTrunk();
            Console.WriteLine("GoodCar Implementation executed successfully.");
        }
        private void Drive()
        {
            _engine.Start();
            _tripLogger.LogTrip();
            _engine.TurnOff();
        }
        private void PlayMusic()
        {
            _musicSystem.TurnOnMusicSystem();
            _musicSystem.IncreaseVolume(10);
            _musicSystem.DecreaseVolume(4);
        }
        private void OpenTrunk()
        {
            _trunk.Open();
            _trunk.Close();
        }
    }
}
