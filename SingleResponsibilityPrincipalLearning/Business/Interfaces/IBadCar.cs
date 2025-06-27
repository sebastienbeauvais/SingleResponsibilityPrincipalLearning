using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrincipalLearning.Business.Interfaces
{
    public interface IBadCar
    {
        void ExecuteBadCarImplementation();
        void StartEngine();
        void Drive();
        void PlayMusic();
        void OpenTrunk();
        void LogTrip();
    }
}
