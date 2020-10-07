using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.SetupFile;

namespace Common
{
 
    public abstract class Animal : IAnimal
    {
        public animalType type { get; private set; }
        public int weight { get; protected set; }
        public int range { get; protected set; } //distance animal can move
        public int weightGain { get; private set; } //weight animal gain when eating grass
        public bool alive { get; protected set; }
        public gender gender { get; private set; }
        public int locationX { get; private set; }
        public int locationY { get; private set; }

        Random random = new Random();

        public Animal(int weight, int range,animalType type, int weightGain)
        {
            
            this.weight = weight;
            this.range = range;
            this.weightGain = weightGain;
            this.type = type;
            alive = true;
            locationX = random.Next(0, Settings.Instance().NumbersOfAreas);
            locationY = random.Next(0, Settings.Instance().NumbersOfAreas);

            if (random.Next(1, 3) == 1)
            {
                this.gender = gender.male;
            }
            else
                gender = gender.female;
        }

        public virtual void Die()
        {
            alive = false;
        }

        public virtual void Eat(int weightChange)
        {
            ChangeWeight(weightChange);
        }

        public virtual void ChangeWeight(int change)
        {
            weight = weight + change;
            
        }
        public void Move()
        {
            
            while (true)
            {
               
                int temp = random.Next(locationX - range, locationX + range + 1);
                if (temp >= 0 && temp < Settings.Instance().NumbersOfAreas)
                {
                    locationX = temp;
                    break;
                }
            }
            while (true)
            {
                int temp = random.Next(locationY - range, locationY + range +1);
                if (temp >= 0 && temp < Settings.Instance().NumbersOfAreas)
                {
                    locationY = temp;
                    break;
                }
            }
            

        }

        public abstract void CheckWeight();

        public override string ToString()
        {
            return $"{type} {gender} {weight}kg at ({locationX},{locationY})";
        }

        
    }
}
