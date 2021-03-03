using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Wagon
    {
        //properties
        public int WagonNumber { get; private set; }
        public int WagonMaxWeight { get; private set; }
        public int WagonCurrentWeight { get; private set; }
        public int WagonAnimalCount { get; private set; }

        //lists
        private List<Animal> wagonAnimals = new List<Animal>();
        public IReadOnlyList<Animal> wagonAnimalsReadOnly => wagonAnimals.AsReadOnly();
        //constructor
        public Wagon(int wagonNumber)
        {
            this.WagonNumber = wagonNumber;
            this.WagonMaxWeight = 10;
            this.WagonCurrentWeight = 0;
            this.WagonAnimalCount = 0;
        }
        //constructor override
        //in case you want to add a bigger wagon
        public Wagon(int wagonNumber, int maxWeight)
        {
            this.WagonNumber = wagonNumber;
            this.WagonMaxWeight = maxWeight;
            this.WagonCurrentWeight = 0;
            this.WagonAnimalCount = 0;
        }
        //methods
        //checks if the animal is added to the wagon
        //returns a bool for the train class
        public bool WagonAddAnimal(Diet diet, Weight weight)
        {
            bool added = false;
            int animalWeight = ConvertWeightClassToInt(weight);
            bool full = CheckIfThereIsRoomInWagon(animalWeight);
            bool compatible = CheckIfTheAnimalIscompatible(diet, weight, WagonCurrentWeight);
            if(full == false && compatible == true)
            {
                AddAnimalToWagon(diet, weight, animalWeight);
                added = true;
            }
            else
            {
                added = false;
            }
            return added;
        }
        //Adds the animal to the wagon and increments the corrosponding values
        private void AddAnimalToWagon(Diet diet, Weight weight, int animalWeight)
        {
            wagonAnimals.Add(new Animal(diet, weight));
            this.WagonCurrentWeight = WagonCurrentWeight + animalWeight;
            this.WagonAnimalCount++;
        }
        //Converts the enum to int
        private int ConvertWeightClassToInt(Weight weight)
        {
            int WeightPoints = Convert.ToInt32(weight);
            return WeightPoints;
        }
        //Checks if there is any room left in the wagon for the animal
        private bool CheckIfThereIsRoomInWagon(int weight)
        {
            bool full = true;
            //If the current wieght is the same as the maximum wieght the animal cant be added (of course)
            if(WagonCurrentWeight == WagonMaxWeight)
            {
                full = true;
            }
            //If the current weight will exceed the maximum weight when the animal weight is added
            //The animal is to big and can't be added tot the wagon
            else if (WagonCurrentWeight + weight > 10)
            {
                full = true;
            }
            else
            {
                full = false;
            }
            return full;
        }
        //checks if all the animals in the wwagon are compatible with the new animal
        private bool CheckIfTheAnimalIscompatible(Diet diet, Weight weight, int usedCapacity)
        {
            bool compatible = false;
            //If there are no animals in the wagon yet, it will always be compatible
            if(WagonCurrentWeight == 0)
            {
                compatible = true;
            }
            else
            {
                foreach (Animal animal in wagonAnimals)
                {
                    compatible = animal.AnimalCompatibilityCheck(diet, weight, usedCapacity);
                    if(compatible == false)
                    {
                        break;
                    }
                }
            }
            return compatible;
        }
        public override string ToString()
        {
           return $"Wagon#{WagonNumber} || Cap: {WagonMaxWeight} || Used-Cap: {WagonCurrentWeight}";
        }
    }
}
