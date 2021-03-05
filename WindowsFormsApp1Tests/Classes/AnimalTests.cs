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
    public class AnimalTests
    {
        [TestMethod()]
        //unit tests AAA
        public void AnimalCompatibilityCheckTest_AddLargeCarnivorToALargeCarnivor_ShouldReturnFalse()
        {
            //assign
            Animal animalLCarnivor = new Animal(Diet.Carnivor, Weight.Large);
            bool compatible;
            //act
            compatible = animalLCarnivor.AnimalCompatibilityCheck(Diet.Carnivor, Weight.Large);
            //assert
            Assert.IsFalse(compatible);
        }

        [TestMethod()]
        public void AnimalCompatibilityCheckTest_AddMediumCarnivorToMeidumHerbivor_ShouldReturnFalse()
        {
            //assign
            Animal animalLCarnivor = new Animal(Diet.Herbivor, Weight.Medium);
            bool compatible;
            //act
            compatible = animalLCarnivor.AnimalCompatibilityCheck(Diet.Carnivor, Weight.Medium);
            //assert
            Assert.IsFalse(compatible);
        }

        [TestMethod()]
        public void AnimalCompatibilityCheckTest_AddMediumCarnivorToSmallHerbivor_ShouldReturnFalse()
        {
            //assign
            Animal animalLCarnivor = new Animal(Diet.Herbivor, Weight.Small);
            bool compatible;
            //act
            compatible = animalLCarnivor.AnimalCompatibilityCheck(Diet.Carnivor, Weight.Medium);
            //assert
            Assert.IsFalse(compatible);
        }

        [TestMethod()]
        public void AnimalCompatibilityCheckTest_AddSmallCarnivorToSmallHerbivor_ShouldReturnFalse()
        {
            //assign
            Animal animalLCarnivor = new Animal(Diet.Herbivor, Weight.Small);
            bool compatible;
            //act
            compatible = animalLCarnivor.AnimalCompatibilityCheck(Diet.Carnivor, Weight.Small);
            //assert
            Assert.IsFalse(compatible);
        }

        [TestMethod()]
        public void AnimalCompatibilityCheckTest_AddLargeHerbivorToLargeHerbivor_ShouldReturnTrue()
        {
            //assign
            Animal animalLCarnivor = new Animal(Diet.Herbivor, Weight.Large);
            bool compatible;
            //act
            compatible = animalLCarnivor.AnimalCompatibilityCheck(Diet.Herbivor, Weight.Large);
            //assert
            Assert.IsTrue(compatible);
        }

        [TestMethod()]
        public void AnimalCompatibilityCheckTest_AddLargeHerbivorToMediumHerbivor_ShouldReturnTrue()
        {
            //assign
            Animal animalLCarnivor = new Animal(Diet.Herbivor, Weight.Large);
            bool compatible;
            //act
            compatible = animalLCarnivor.AnimalCompatibilityCheck(Diet.Herbivor, Weight.Medium);
            //assert
            Assert.IsTrue(compatible);
        }

        [TestMethod()]
        public void AnimalCompatibilityCheckTest_AddLargeHerbivorToSmallHerbivor_ShouldReturnTrue()
        {
            //assign
            Animal animalLCarnivor = new Animal(Diet.Herbivor, Weight.Large);
            bool compatible;
            //act
            compatible = animalLCarnivor.AnimalCompatibilityCheck(Diet.Herbivor, Weight.Small);
            //assert
            Assert.IsTrue(compatible);
        }

        [TestMethod()]
        public void AnimalCompatibilityCheckTest_AddMediumnHerbivorToMediumHerbivor_ShouldReturnTrue()
        {
            //assign
            Animal animalLCarnivor = new Animal(Diet.Herbivor, Weight.Medium);
            bool compatible;
            //act
            compatible = animalLCarnivor.AnimalCompatibilityCheck(Diet.Herbivor, Weight.Medium);
            //assert
            Assert.IsTrue(compatible);
        }

        [TestMethod()]
        public void AnimalCompatibilityCheckTest_AddMediumnHerbivorToSmallHerbivor_ShouldReturnTrue()
        {
            //assign
            Animal animalLCarnivor = new Animal(Diet.Herbivor, Weight.Medium);
            bool compatible;
            //act
            compatible = animalLCarnivor.AnimalCompatibilityCheck(Diet.Herbivor, Weight.Small);
            //assert
            Assert.IsTrue(compatible);
        }

        [TestMethod()]
        public void AnimalCompatibilityCheckTest_AddSmallHerbivorToSmallHerbivor_ShouldReturnTrue()
        {
            //assign
            Animal animalLCarnivor = new Animal(Diet.Herbivor, Weight.Small);
            bool compatible;
            //act
            compatible = animalLCarnivor.AnimalCompatibilityCheck(Diet.Herbivor, Weight.Small);
            //assert
            Assert.IsTrue(compatible);
        }

        [TestMethod()]
        public void AnimalCompatibilityCheckTest_AddCarnivorTolargerHerbivor_ShouldReturnFalse()
        {
            //assign
            Animal animalLCarnivor = new Animal(Diet.Herbivor, Weight.Medium);
            bool compatible;
            //act
            compatible = animalLCarnivor.AnimalCompatibilityCheck(Diet.Carnivor, Weight.Small);
            //assert
            Assert.IsTrue(compatible);
        }
    }
}