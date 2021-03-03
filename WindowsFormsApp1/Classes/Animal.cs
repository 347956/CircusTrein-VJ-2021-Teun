using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Animal
    {
        //properties
        public Diet Diet { get; private set; }
        public Weight Weight { get; private set; }

        //contructor
        public Animal(Diet diet, Weight weight)
        {
            this.Diet = diet;
            this.Weight = weight;
        }
        //methods
        public bool AnimalCompatibilityCheck (Diet diet, Weight weight, int wagonUsedCapacity)
        {            
            bool compatible = false;
            //A large Carnivor is only Compatible when there are no other animals
            if (diet == Diet.Carnivor && weight == Weight.Large && wagonUsedCapacity == 0)
            {
                compatible = true;
            }
            //Two Carnivors are never compatible
            else if (Diet == Diet.Carnivor && diet == Diet.Carnivor)
            {
                compatible = false;
            }
            //Two herbivors will always we compatible
            else if(Diet == Diet.Herbivor && diet == Diet.Herbivor)
            {
                compatible = true;
            }
            //If the animal inside the wagon is already a Carnivor
            else if (Diet == Diet.Carnivor)
            {
                compatible = InternalCarnivorCompatibilityCheck(weight);
            }
            //If the animal that's going to be added is a Carnivor
            else if(diet == Diet.Carnivor)
            {
                compatible = ExternalCarnivorCompatibilityCheck(weight);
            }
            else
            {
                compatible = false;
            }

            return compatible;
        }
        //Checks if the animals are compatible if the to be added animal is a Carnivor
        private bool ExternalCarnivorCompatibilityCheck(Weight weight)
        {
            bool compatible;
            //Is the new Carnivor bigger or the same as the current animal
            if (weight >= Weight)
            {
                compatible = false;
            }
            //Is the new Carnivor smaller than the current animal
            else if(weight < Weight)
            {
                compatible = true;
            }
            else
            {
                compatible = false;
            }
            return compatible;
        }
        //Checks if the animals are compatible when this animal is a Carnivor
        private bool InternalCarnivorCompatibilityCheck(Weight weight)
        {
            bool compatible;
            //Is the current Carnivor bigger or the same as the new animal
            if (Weight >= weight)
            {
                compatible = false;
            }
            //Is the Current Carnivor smaller than the new animal
            else if (Weight < weight)
            {
                compatible = true;
            }
            else
            {
                compatible = false;
            }
            return compatible;
        }

        public override string ToString()
        {
            return $"Diet = {Diet} | Weight = {Weight}";
        }
    }
}
