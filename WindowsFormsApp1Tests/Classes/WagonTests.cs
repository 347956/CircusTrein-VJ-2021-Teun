using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Tests
{
    [TestClass()]
    public class WagonTests
    {
        [TestMethod()]
        //Tests if the animal will be added when the weight reaches the max weight(assuming the default max weight = 10)
        public void WagonAddAnimalTest_AddTwoLargeAnimalsToReachMaxWeight_shouldReturnTrue()
        {
            //assign
            Wagon wagon = new Wagon(1);
            bool added;
            //act
            wagon.WagonAddAnimal(Diet.Herbivor, Weight.Large);
            added = wagon.WagonAddAnimal(Diet.Herbivor, Weight.Large);
            //assert
            Assert.IsTrue(added);
        }

        [TestMethod()]
        //Tests if the animal will be added when the weight exceeds the max weight (assuming the default max weight = 10)
        public void WagonAddAnimalTest_AddThreeLargeAnimalsToExceedMaxWeight_ShouldReturnFalse()
        {
            //assign
            Wagon wagon = new Wagon(1);
            bool added;
            //act
            wagon.WagonAddAnimal(Diet.Herbivor, Weight.Large);
            wagon.WagonAddAnimal(Diet.Herbivor, Weight.Large);
            added = wagon.WagonAddAnimal(Diet.Herbivor, Weight.Large);
            //assert
            Assert.IsFalse(added);
        }

        [TestMethod()]
        //thhis has to be added in the wagon because the methods in the animal class will always return false(A Large Carnivor is always incompatible)
        //A large carnivor can thus only be added to an empty wagon
        public void WagonAddAnimalTest_AddLargeCarnivorToAnEmptyWagon_ShouldReturnTrue()
        {
            //assign
            Wagon wagon = new Wagon(1);
            bool added;
            //act
            added = wagon.WagonAddAnimal(Diet.Carnivor, Weight.Large);
            Assert.IsTrue(added);
        }
    }
}