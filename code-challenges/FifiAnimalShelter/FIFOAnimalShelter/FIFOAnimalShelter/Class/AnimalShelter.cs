using System;
using System.Collections.Generic;
using System.Text;
using stack_and_queue;

namespace FIFOAnimalShelter.Class
{
    class AnimalShelter
    {
        public Queue<Animal> Shelter = new Queue<Animal>();

        public object Animal { get; internal set; }


        /// <summary>
        /// Adds an animal to the shelter
        /// </summary>
        /// <param name="animal"></param>
        public void Enqueue(Animal animal)
        {
            Shelter.Enqueue(animal);
        }


        /// <summary>
        /// Return a cat or a dog
        /// </summary>
        /// <param name="pref">dog or cat string</param>
        public Animal Dequeue(string pref)
        {
            Animal animalPref = new Animal();
            if (pref == "dog")
            {
                animalPref = new Dog();
            }
            else if (pref == "cat")
            {
                animalPref = new Cat();
            }
            else
            {
                animalPref = null;
             
            }
            return animalPref;
        }
        
        
    }
}
