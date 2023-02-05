using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Animal
    {
        public string name;
        public string Name { get; set; }

        public Animal() { }

        public Animal(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
