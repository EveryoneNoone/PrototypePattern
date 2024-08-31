using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class Cat : Mammal
    {
        /// <summary>
        /// окрас шерсти
        /// </summary>
        public string FurColor { get; set; }

        public Cat() { }

        public Cat(Cat other) : base(other)
        {
            FurColor = other.FurColor;
        }

        public override Cat MyClone()
        {
            return new Cat(this);
        }

        public override object Clone()
        {
            return MyClone();
        }
    }
}
