using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SetupFile;

namespace Entity
{
    public class Rabbit : Animal
    {
        public Rabbit(int weight, int range, animalType type, int weightGain) : base(weight, range, type, weightGain)
        {

        }
        public override void CheckWeight()
        {
            if (weight < Settings.rabbitMinWeight)
                Die();
        }

        public override void Die()
        {
            alive = false;
        }

        public override void ChangeWeight(int change)
        {
            weight = weight + change;
            if (weight > Settings.rabbitMaxWeight)
                weight = Settings.rabbitMaxWeight ;
        }

        public override void Eat()
        {
            throw new NotImplementedException();
        }
    }
}
