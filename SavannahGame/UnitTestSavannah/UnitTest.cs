using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;
using Common;
using System.IO.Pipes;

namespace UnitTestSavannah
{
    [TestClass]
    public class UnitTest
    {

        [TestMethod]
        [DataRow (animalType.lion,animalType.lion)]
        [DataRow (animalType.rabbit,animalType.rabbit)]
        public void CreateAnimal_expectedSameAnimalType(animalType typeInput, animalType expected)
        {
            //Arrange

            //Act
            animalType typeActual = AnimalFactory.Instance().CreateAnimal(typeInput).type;
            //Assert

            Assert.AreEqual(expected, typeActual);
        }


        [TestMethod]
        [DataRow (10,10)]
        [DataRow(7,7)]
        public void GetGameSpeed_expectedSameInputOutput(int input, int expected)
        {
            //Arrange
            Game_Controller.Instance().SetGameSpeed(input);
            //Act
            int speedActual = Game_Controller.Instance().GetGameSpeed();

            //Assert
            Assert.AreEqual(expected, speedActual);
        }


    }
}
