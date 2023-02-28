using Animals.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Model
{
    public class AnimalCounter
    {
        private List<Animal> animals;
        private int maxId;

        public AnimalCounter()
        {
            animals = new List<Animal>();
        }

        public int Count { get => maxId;}
        public List<Animal> Animals { get => animals;}

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
            animal.Id = maxId;
            maxId++;
        }

        public bool DelAnimal(int id)
        {
            foreach (Animal animal in animals) { 
                if (animal.Id == id)
                {
                    animals.Remove(animal);
                    return true;    
                }
            }
            return false;
        }

        public int FindIdByName(string name)
        {
            foreach (Animal animal in animals)
            {
                if (animal.Name == name) return animal.Id;  
            }
            return 0;
        }
    }
}
