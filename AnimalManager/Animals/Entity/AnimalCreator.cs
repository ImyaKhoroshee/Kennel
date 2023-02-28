using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Entity
{
    public static class AnimalCreator
    {
        public static Animal NewCat(string name, int age) => new Cat(name, age);
        public static Animal NewDog(string name, int age) => new Dog(name, age);
        public static Animal NewHorse(string name, int age) => new Horse(name, age);
        public static Animal NewDonkey(string name, int age) => new Donkey(name, age);

        public static Animal NewAnimal(string typeAnimal, string name, int age)
        {
            switch (typeAnimal)
            {
                case "Cat": return NewCat(name, age);
                case "Dog": return NewDog(name, age);
                case "Horse": return NewHorse(name, age);
                case "Donkey": return NewDonkey(name, age);
            }

            throw new Exception($"Unknown animal type {typeAnimal}");
        }

    }
}
