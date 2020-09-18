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

        //public static void MaleLionsFight(ref List<Animal> animalList, ref List<string> incidentList)
        //{
        //    for (int i = 0; i < animalList.Count; i++)
        //    {
        //        for (int j = 1 + i; j < animalList.Count; j++)
        //        {
        //            if (animalList[i].type == animalType.lion &&
        //                            animalList[i].type == animalList[j].type &&
        //                            animalList[i].gender == gender.male &&
        //                            animalList[i].gender == animalList[j].gender)
        //            {
        //                if (animalList[i].weight > animalList[j].weight)
        //                {
        //                    incidentList.Insert(0, $"Lion dies because it only weighs {animalList[j].weight}kg ({animalList[i].gender}) in the fight against one at {animalList[i].weight}kg ({animalList[j].gender})\tThe fight happened at the position {animalList[i].locationX},{animalList[i].locationY}");
        //                    animalList.RemoveAt(j);
        //                }
        //                else
        //                {
        //                    incidentList.Insert(0, $"Lion dies because it only weighs {animalList[i].weight}kg ({animalList[i].gender}) in the fight against one at {animalList[j].weight}kg ({animalList[j].gender})\tThe fight happened at the position {animalList[i].locationX},{animalList[i].locationY}");
        //                    animalList.RemoveAt(i);
        //                }
        //            }
        //        }
        //    }
        //}

        public override void CheckWeight()
        {
            if (weight < Settings.Instance().lionMinWeight)
                Die();
        }

        //public override void Die()
        //{
        //    alive = false;
        //}

        public override void ChangeWeight(int change)
        {
            weight = weight + change;
            if (weight > Settings.Instance().LionMaxWeight)
                weight = Settings.Instance().LionMaxWeight;
        }


        //public override void Eat()
        //{
        //    throw new NotImplementedException();
        //}

        

    }
}
