using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class Dog : Mammal
    {
        /// <summary>
        /// порода
        /// </summary>
        public string Breed { get; set; }

        public Dog() { }

        public Dog(Dog other) : base(other)
        {
            Breed = other.Breed;
        }

        public override Dog MyClone()
        {
            return new Dog(this);
        }

        public override object Clone()
        {
            return MyClone();
        }
    }
}
