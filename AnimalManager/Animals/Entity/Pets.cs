using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Entity
{
    public abstract class Pets : Animal
    {
        protected int mimimiLevel;
        public Pets(string name, int age) : base(name, age)
        {
        }

        public int MimimiLevel { get => mimimiLevel; }
    }
}
