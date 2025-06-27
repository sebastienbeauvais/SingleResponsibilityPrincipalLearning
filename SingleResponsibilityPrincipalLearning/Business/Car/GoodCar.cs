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
    }
}
