using Common;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.SetupFile;

namespace BusinessLogic
{
    public class SavannahGame
    {
        public Area[,] areaArray { get; private set; } = new Area[Settings.Instance().NumbersOfAreas, Settings.Instance().NumbersOfAreas];
        public List<Animal> animalList { get; private set; } = new List<Animal>();
        public List<string> IncidentsList { get; private set; } = new List<string>();

       

        public SavannahGame() //assign areas to the savannah
        {
            Random r = new Random();
            //int count = 1;
            for (int i = 0; i < areaArray.GetLength(0); i++)
            {
                for (int j = 0; j < areaArray.GetLength(1); j++)
                {
                    areaArray[i, j] = new Area(r.Next(1, 4)); //random is used to generate grass in constructor
                    //count++;
                }
            }
            IncidentsList.Add("it was a sunny day on the savannah");
        }
        

        
        public void NewLion()
        {
            Random r = new Random();
            animalList.Add(new Lion(r.Next(Settings.Instance().lionMinWeight + 7, Settings.Instance().lionMaxBornWeight), Settings.Instance().lionRange,animalType.lion, Settings.Instance().lionWeightGain));
        }

        public void NewRabbit()
        {
            Random r = new Random();
            animalList.Add(new Rabbit(r.Next(Settings.Instance().rabbitMinWeight + 2, Settings.Instance().rabbitMaxBornWeight), Settings.Instance().rabbitRange, animalType.rabbit, Settings.Instance().rabbitWeightGain));
        }


        public void MoveAnimals()
        {
            //for (int i = 0; i < 2000000000; i++)
            //{
            //    i++;
            //}
            //move animals to new location
            foreach (var animal in animalList)
            {
                animal.Move();
                AnimalEatsGrass(animal);
                animal.CheckWeight();

            }
            //check if animals is alive. If not it's removed from list
            for (int i = animalList.Count - 1; i >= 0; i--)
            {
                if (!animalList[i].alive)
                {
                    IncidentsList.Insert(0, $"{animalList[i].type} ({animalList[i].gender}) at at the position {animalList[i].locationX},{animalList[i].locationY} dies by hunger ({animalList[i].weight})kg");
                    animalList.Remove(animalList[i]);
                }

            }
        }

        public void AnimalsCheck_SameLocation()
        {
            for (int i = 0; i < animalList.Count; i++)
            {
                for (int j = 1+i; j < animalList.Count; j++)
                {
                    //check for same location
                    if (animalList[i].locationX == animalList[j].locationX &&
                        animalList[i].locationY == animalList[j].locationY)
                    {
                        //same type different gender = new animal
                        if (animalList[i].type == animalList[j].type &&
                            animalList[i].gender != animalList[j].gender)
                        {
                            AnimalsMate(animalList[i].type);
                            //continue;
                        }
                        //Lion always eats rabbits
                        else if (animalList[i].type != animalList[j].type)
                        {
                            if (animalList[i].type == animalType.lion)
                            {
                                IncidentsList.Insert(0, $"A {animalList[i].type} eats a {animalList[j].type} and gain {animalList[j].weight/2}kg");
                                animalList[i].ChangeWeight(animalList[j].weight / 2);
                                animalList.RemoveAt(j);
                                j--;  //items are renumbered and has to be checked again. example [3] is removed [4] becomes [3] etc. 
                                //continue;
                            }
                            else
                            {
                                IncidentsList.Insert(0, $"A {animalList[j].type} eats a {animalList[i].type} and gain {animalList[i].weight / 2}kg");
                                animalList[j].ChangeWeight(animalList[i].weight / 2);
                                animalList.RemoveAt(i);
                                i--;
                                break; //breaks for loop[j] and checks the new [i] again
                            } 
                        }
                        //male lions fight
                        else if (animalList[i].type == animalType.lion &&
                            animalList[i].type == animalList[j].type &&
                            animalList[i].gender == gender.male &&
                            animalList[i].gender == animalList[j].gender)
                        {
                            if (animalList[i].weight > animalList[j].weight)
                            {
                                IncidentsList.Insert(0, $"Lion dies because it only weighs {animalList[j].weight}kg ({animalList[i].gender}) in the fight against one at {animalList[i].weight}kg ({animalList[j].gender})\tThe fight happened at the position {animalList[i].locationX},{animalList[i].locationY}");
                                animalList.RemoveAt(j);
                                j--; 
                                
                            }
                            else
                            {
                                IncidentsList.Insert(0, $"Lion dies because it only weighs {animalList[i].weight}kg ({animalList[i].gender}) in the fight against one at {animalList[j].weight}kg ({animalList[j].gender})\tThe fight happened at the position {animalList[i].locationX},{animalList[i].locationY}");
                                animalList.RemoveAt(i);
                                i++;
                                break; //breaks for loop[j] and checks the new [i] again
                            }
                        }

                         
                        
                        
                    }
                }
            }
        }

        

        private void AnimalEatsGrass(Animal animal)
        {
            if (areaArray[animal.locationX, animal.locationY].ContainsGrass() == true)
            {
                animal.Eat(animal.weightGain);
                areaArray[animal.locationX, animal.locationY].GrassEaten();
            }
            else
            {
                Random r = new Random();
                animal.ChangeWeight(r.Next(-1, 1));

            }
        }
        public void AnimalsMate(animalType type)
        {
            if (type == animalType.lion)
            {
                NewLion();
                IncidentsList.Insert(0, "A new Lion was born");
            }
            else if (type == animalType.rabbit)
            {
                Random r = new Random();
                int temp = r.Next(1, 3);
                for (int k = 0; k < temp; k++)
                {
                    NewRabbit();
                }

                IncidentsList.Insert(0,$"{temp} new rabbits was born");
            }
            
        }

        public void GrassGrows()
        {
            Random r = new Random();
            int count = 0;
            for (int i = 0; i < areaArray.GetLength(0); i++)
            {
                for (int j = 0; j < areaArray.GetLength(1); j++)
                {
                    if (!areaArray[i,j].ContainsGrass())
                    {
                        
                        if (r.Next(0, 100/ Settings.Instance().grassGrowSpeed) == 0)
                        {
                            areaArray[i, j].GrassGrows();
                            count++;
                        }
                    }
                }
            }
        }

    }
}



