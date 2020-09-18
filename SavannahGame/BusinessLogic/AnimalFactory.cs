using Common;
using Common.SetupFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLogic
{
    public class AnimalFactory
    {
        private static AnimalFactory _instance = null;

        private AnimalFactory()
        {
        }
        
        public static AnimalFactory Instance()
        {
            if (_instance == null)
            {
                _instance = new AnimalFactory();
            }
            return _instance;
        }

        public Animal CreateAnimal(animalType type)
        {
            Random r = new Random();
            switch (type)
            {
                case animalType.lion:
                    return new Lion(
                        r.Next(Settings.Instance().lionMinWeight + 7,
                        Settings.Instance().lionMaxBornWeight),
                        Settings.Instance().lionRange,
                        Settings.Instance().lionWeightGain);
                case animalType.rabbit:
                    return new Rabbit(
                        r.Next(Settings.Instance().rabbitMinWeight + 2,
                        Settings.Instance().rabbitMaxBornWeight),
                        Settings.Instance().rabbitRange,
                        Settings.Instance().rabbitWeightGain);
                default:
                    return null;
                    
            }


        }
    }
}
