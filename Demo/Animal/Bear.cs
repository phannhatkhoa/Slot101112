using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Bear:Mammal
    {
        public Bear() { }
        public Bear(string name) : base(name)
        {
            this.Name = "Bear";
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
