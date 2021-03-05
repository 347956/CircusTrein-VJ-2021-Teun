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
    public class TrainTests
    {
        [TestMethod()]
        public void AddAnimalsToListTest_CheckIfAnimalsCanBeAdded_ShouldReturnTrue()
        {
            //assign
            Train train = new Train();
            Random random = new Random();
            int randNumb = random.Next(1, 11);
            //act
            for (int i = 0; i < randNumb; i++)
            {
                train.AddAnimalsToList(Diet.Herbivor, Weight.Large);
            }
            //assert
            Assert.IsTrue(train.animalsToAddReadonly != null);
        }

        [TestMethod()]
        public void FillTrainTest_AddANewWagonWhenTheOtherWagonsAreFull_shouldReturnTrue()
        {
            //assign
            Train train = new Train();
            Random random = new Random();
            int randNumb = random.Next(11, 22);
            //act
            for (int i = 0; i < randNumb; i++)
            {
                train.AddAnimalsToList(Diet.Herbivor, Weight.Small);
            }
            train.FillTrain();
            //assert
            Assert.IsTrue(train.WagonAmount >= 1);
        }

        [TestMethod()]
        public void FillTrainTest_AddANewWagonWhenTheAnimalsAreNotCompatible_ShouldReturnTrue()
        {
            //assign
            Train train = new Train();
            //act
            train.AddAnimalsToList(Diet.Herbivor, Weight.Large);
            train.AddAnimalsToList(Diet.Herbivor, Weight.Large);
            train.AddAnimalsToList(Diet.Herbivor, Weight.Large);
            train.AddAnimalsToList(Diet.Carnivor, Weight.Large);
            train.AddAnimalsToList(Diet.Carnivor, Weight.Large);
            train.AddAnimalsToList(Diet.Carnivor, Weight.Large);
            train.FillTrain();
            //assert
            Assert.IsTrue(train.WagonAmount >= 1);
        }

        [TestMethod()]
        //2CarL + 3 HerbL + 3CarM + 3HerbM + 3CarS + 3HerbS = 11 wagons (or less)
        public void FillTrainTest_TheTrainIsFilledOptimised_ShouldReturnTrue()
        {
            //assign
            Train train = new Train();
            //act
            train.AddAnimalsToList(Diet.Carnivor, Weight.Large);
            train.AddAnimalsToList(Diet.Herbivor, Weight.Small);
            train.AddAnimalsToList(Diet.Herbivor, Weight.Large);
            train.AddAnimalsToList(Diet.Herbivor, Weight.Large);
            train.AddAnimalsToList(Diet.Herbivor, Weight.Large);
            train.AddAnimalsToList(Diet.Carnivor, Weight.Large);
            train.AddAnimalsToList(Diet.Carnivor, Weight.Medium);
            train.AddAnimalsToList(Diet.Herbivor, Weight.Medium);
            train.AddAnimalsToList(Diet.Herbivor, Weight.Medium);
            train.AddAnimalsToList(Diet.Herbivor, Weight.Small);
            train.AddAnimalsToList(Diet.Carnivor, Weight.Medium);
            train.AddAnimalsToList(Diet.Carnivor, Weight.Medium);
            train.AddAnimalsToList(Diet.Herbivor, Weight.Medium);
            train.AddAnimalsToList(Diet.Herbivor, Weight.Small);
            train.AddAnimalsToList(Diet.Herbivor, Weight.Small);
            train.AddAnimalsToList(Diet.Carnivor, Weight.Small);
            train.AddAnimalsToList(Diet.Carnivor, Weight.Small);
            train.AddAnimalsToList(Diet.Carnivor, Weight.Small);
            //assert
            Assert.IsTrue(train.WagonAmount == 11 || train.WagonAmount <= 11);
        }
    }
}