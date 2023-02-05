using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Snake : Reptile
    {
        public Snake() { }
        public Snake(string name) : base(name)
        {
            this.Name = "Snake";
        }
        public override string ToString()
        {
            return Name;
        }
    }

}
