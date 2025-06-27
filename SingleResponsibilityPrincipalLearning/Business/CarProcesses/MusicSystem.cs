using SingleResponsibilityPrincipalLearning.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrincipalLearning.Business.CarProcesses
{
    public class MusicSystem : IMusicSystem
    {
        private int volume = 1;
        public MusicSystem() { }
        public void TurnOnMusicSystem()
        {
            Console.WriteLine("Music system has been turned on");
        }
        public void TurnOffMusicSystem()
        {
            Console.WriteLine("Music system has been turned off");
        }
        public void IncreaseVolume(int volumeToIncrease)
        {
            var currentVolumn = volume;
            if (currentVolumn < 10 && (currentVolumn + volumeToIncrease <= 10) )
            {
                volume += 1;
                Console.WriteLine("Volume set to: " + volume);
            }
            else if(currentVolumn + volumeToIncrease > 10)
            {
                volume = 10;
                Console.WriteLine("Volume set to max: " + volume);
            }
            else
            {
                Console.Write("Volume already set to max");
            }
        }
        public void DecreaseVolume(int volumeToDecrease) 
        {
            var currentVolumn = volume;
            if (currentVolumn > 0)
            {
                volume -= 1;
                Console.WriteLine("Volume set to: " + volume);
            }
            else
            {
                Console.Write("Volume already set to min");
            }
        }
    }
}
