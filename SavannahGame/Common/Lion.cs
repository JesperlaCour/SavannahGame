using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.SetupFile;


namespace Common
{
    public class Lion : Animal
    {
        
        public Lion(int weight, int range,int weightGain) : base(weight, range,animalType.lion,weightGain)
        {
        }

        public override void CheckWeight()
        {
            if (weight < Settings.Instance().lionMinWeight)
                Die();
        }


        public override void ChangeWeight(int change)
        {
            weight = weight + change;
            if (weight > Settings.Instance().LionMaxWeight)
                weight = Settings.Instance().LionMaxWeight;
        }
    }
}
