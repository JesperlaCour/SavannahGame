using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace BusinessLogic
{
    public sealed class Game_Controller
    {
        private static Game_Controller _instance;
        private SavannahGame savannah = new SavannahGame();

        private Game_Controller()
        {
        }

        public static Game_Controller Instance()
        {
            if (_instance == null)
            {
                _instance = new Game_Controller();
            }
            return _instance;
        }

        public void ResetGame()
        {
            savannah = new SavannahGame();
        }

        public void NewAnimal(animalType animalType)
        {
            savannah.NewAnimal(animalType);
        }

        public void AnimalIteration()
        {
            savannah.MoveAnimals();
            savannah.AnimalsCheck_SameLocation();
            savannah.GrassGrows();
        }

        public void MoveAnimals()
        {
            savannah.MoveAnimals();
        }

        public void AnimalsSameLocation()
        {
            savannah.AnimalsCheck_SameLocation();
        }

        public void GrassGrows()
        {
            savannah.GrassGrows();
        }

        public List<string> GetIncidentList()
        {
            return savannah.IncidentsList;
        }

        public List<Animal> GetAnimalList()
        {
            return savannah.animalList;
        }

        public Area[,] GetAreaArray()
        {
            return savannah.areaArray;
        }

        public void SaveGameHistory(string filePath)
        {
            savannah.SaveGameHistory(filePath);
        }






    }
}
