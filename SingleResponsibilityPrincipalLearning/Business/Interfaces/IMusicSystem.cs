using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrincipalLearning.Business.Interfaces
{
    public interface IMusicSystem
    {
        void TurnOnMusicSystem();
        void TurnOffMusicSystem();
        void IncreaseVolume();
        void DecreaseVolume();
    }
}
