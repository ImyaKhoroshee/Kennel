using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Entity
{
    public abstract class Animal
    {
        private AnimalType type;

        private int id;
        private string name;
        private int age;

        protected Animal(string name, int age)
        {
            this.id = 0;
            this.name = name;
            this.age = age;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }        
    }
}
