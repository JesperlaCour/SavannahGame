using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.SetupFile;

namespace Common
{
    public class Rabbit : Animal
    {
        public Rabbit(int weight, int range, int weightGain) : base(weight, range, animalType.rabbit, weightGain)
        {

        }
        public override void CheckWeight()
        {
            if (weight < Settings.Instance().rabbitMinWeight)
                Die();
        }

        public override void ChangeWeight(int change)
        {
            weight = weight + change;
            if (weight > Settings.Instance().rabbitMaxWeight)
                weight = Settings.Instance().rabbitMaxWeight ;
        }
    }
}
