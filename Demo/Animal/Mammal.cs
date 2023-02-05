using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Mammal : Animal
    {
        public Mammal() { }
        public Mammal(string name) : base(name)
        {
            this.Name = "Mammal";
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
