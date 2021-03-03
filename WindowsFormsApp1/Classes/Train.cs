using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Train
    {
        //properties
        public string Name { get; private set; }
        public int WagonAmount { get; private set; }
        public int AnimalCount { get; private set; }

        //lists
        private List<Wagon> wagons = new List<Wagon>();
        private List<Animal> animalsToAdd = new List<Animal>();
        public IReadOnlyList<Wagon> WagonsRadonly => wagons.AsReadOnly();

        //constructor
        public Train()
        {
            this.Name = "Circus-Train";
            this.WagonAmount = 0;
            this.AnimalCount = 0;
        }

        //methods
        //sets the animals in the to be added list
        public void AddAnimalsToList(Diet diet, Weight weight)
        {
            animalsToAdd.Add(new Animal(diet, weight));
        }
        //Starts filling the wagons with the animals
        public void FillTrain()
        {
            SortAnimalList();
            FillWagons();
            EmptyAnimalList();
        }

        //private Methods
        //sorts the animal list so that the animals will get added in the propper order
        private void SortAnimalList()
        {
            animalsToAdd = animalsToAdd.OrderByDescending(animal => animal.Diet).ThenByDescending(animal => animal.Weight).ToList();
            AnimalCount = AnimalCount + animalsToAdd.Count();
        }
        //Empties the List of to be added animals
        private void EmptyAnimalList()
        {
            animalsToAdd.Clear();
        }
        //adds a wagon to the train
        private void AddWagon()
        {
            WagonAmount++;
            wagons.Add(new Wagon(WagonAmount));            
        }
        //put the animals into the wagons
        private void FillWagons()
        {
            AddWagon();
            foreach (Animal animal in animalsToAdd)
            {
                //when the check returns fals, a new wagon must be made for the incompatible animal, and in needs to be added again
                if(PutAnimalInWagon(animal) == false)
                {
                    AddWagon();
                    PutAnimalInWagon(animal);
                }
            }
        }
        //Checks if animal was added or not, adds the animal = return true, unable to add returns false
        private bool PutAnimalInWagon(Animal animal)
        {
            foreach (Wagon wagon in wagons)
            {
                if(wagon.WagonAddAnimal(animal.Diet, animal.Weight) == true)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
