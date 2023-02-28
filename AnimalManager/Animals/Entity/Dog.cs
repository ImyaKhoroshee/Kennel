using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Entity
{
    public class Dog : HomeAnimal
    {
        public Dog(string name, int age) : base(name, age)
        {
            mimimiLevel = 200;
        }
    }
}
