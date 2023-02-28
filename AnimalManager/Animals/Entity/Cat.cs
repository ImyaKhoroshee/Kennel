using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Entity
{
    public class Cat : HomeAnimal
    {
        public Cat(string name, int age) : base(name, age)
        {
            mimimiLevel = 100;
        }
    }
}
