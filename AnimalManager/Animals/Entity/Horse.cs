using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Entity
{
    internal class Horse : PackAnimal
    {
        public Horse(string name, int age) : base(name, age)
        {
            maxWeight = 400;
        }
    }
}
