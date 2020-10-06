using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;
using Common;

namespace UnitTestSavannah
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            AnimalFactory.Instance().CreateAnimal(animalType.lion);

            //Act

            //Assert
            
        }
    }
}
