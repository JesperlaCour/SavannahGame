using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.SetupFile
{
    public sealed class Settings
    {
        private static Settings _instance;

        //settings for simulation
        public int gameSpeed { get; private set; } = 4; //1000ms/speed. Higher int = faster

        //settings for graphic
        public int areaSize { get; private set; } = 400;

        //settings for savannah
        public int NumbersOfAreas { get; private set; }
        public int grassGrowSpeed { get; private set; } = 1; //1 very slow - 100 extremely fast

        //settings for lions
        public int lionRange { get; private set; } = 1;
        public int lionMinWeight { get; private set; } = 10; //min weight before lion starves
        public int lionMaxBornWeight { get; private set; } = 25;
        public int lionWeightGain { get; set; } = 2;
        public int LionMaxWeight { get; set; } = 75;

        //settings for rabbits
        public int rabbitRange { get; set; } = 2;
        public int rabbitMinWeight { get; private set; } = 1;
        public int rabbitMaxBornWeight { get; set; } = 5;
        public int rabbitWeightGain { get; set; } = 2;
        public int rabbitMaxWeight { get; set; } = 20;

        private Settings()
        {
            NumbersOfAreas = areaSize / 20;
        }

        public static Settings Instance()
        {
            if (_instance == null)
            {
                _instance = new Settings();
            }
            return _instance;
        }

        public void SetGameSpeed(int gameSpeed)
        {
            this.gameSpeed = gameSpeed;
        }

        public void SetGrassGrowSpeed(int grassGrow)
        {
            this.grassGrowSpeed = grassGrow;
        }


    }
}
