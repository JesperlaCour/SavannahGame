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
        public Rabbit(int weight, int range, animalType type, int weightGain) : base(weight, range, type, weightGain)
        {

        }
        public override void CheckWeight()
        {
            if (weight < Settings.Instance().rabbitMinWeight)
                Die();
        }

        //public override void Die()
        //{
        //    alive = false;
        //}

        public override void ChangeWeight(int change)
        {
            weight = weight + change;
            if (weight > Settings.Instance().rabbitMaxWeight)
                weight = Settings.Instance().rabbitMaxWeight ;
        }

        //public override void Eat(int change)
        //{
        //    ChangeWeight(6);
        //}
    }
}
