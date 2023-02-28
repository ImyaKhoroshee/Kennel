using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Entity
{
    public abstract class Beasts : Animal
    {
        protected int maxWeight;
        public Beasts(string name, int age) : base(name, age)
        {
        }

        public int MaxWeight { get => maxWeight; }
    }
}
