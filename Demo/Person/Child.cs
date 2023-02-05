using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Child : Person
    {
        public Child() { }
        public Child(string name, int age) : base(name, age)
        {
            if (age > 15)
            {
                throw new ArgumentException("Age of a child cannot be more than 15.");
            }
        }
        public override string ToString()
        {
            return $"Child: " + base.ToString();
        }
    }
}
