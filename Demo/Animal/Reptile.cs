using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Reptile: Animal
    {
        public Reptile() { }
        public Reptile(string name) : base(name) {
            this.Name = "Reptile ";
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
