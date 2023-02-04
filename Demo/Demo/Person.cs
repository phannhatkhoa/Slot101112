using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Person
    {
        
        public string Name { get; set; }
        public string Address { get; set; }

        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }
        public Person()
        {
        }
        public virtual void Print()
        {
            Console.WriteLine($"Name: {Name}, Address: {Address}");
        }

        public override string ToString()
        {
            return $"Name: {Name}, Address: {Address}";
        }
    }
}
