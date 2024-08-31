using PrototypePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class Animal : IMyClonable<Animal>, ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal() { }

        public Animal(Animal other)
        {
            Name = other.Name;
            Age = other.Age;
        }

        public virtual Animal MyClone()
        {
            return new Animal(this);
        }

        public virtual object Clone()
        {
            return MyClone();
        }
    }
}
