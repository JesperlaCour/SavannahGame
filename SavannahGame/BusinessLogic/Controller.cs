using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace BusinessLogic
{
    public sealed class Controller
    {
        private static Controller _instance;
        private SavannahGame savannah = new SavannahGame();

        private Controller()
        {
        }

        public static Controller Instance()
        {
            if (_instance == null)
            {
                _instance = new Controller();
            }
            return _instance;
        }

        public void ResetGame()
        {
            savannah = new SavannahGame();
        }

        public void NewLion()
        {
            savannah.NewLion();
        }
        public void NewRabbit()
        {
            savannah.NewRabbit();
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






    }
}
