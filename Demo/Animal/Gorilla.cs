using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Gorilla:Mammal
    {
        public Gorilla() { }
        public Gorilla(string name) : base(name)
        {
            this.Name = "Gorilla";
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
