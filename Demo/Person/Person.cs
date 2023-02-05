using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Person
    {
        public string name;
        public int age;
        public string Name { get; set; }
        public int Age { get; set; }
        public Person() { }

        public Person(string name, int age)
        {
            if (age < 0)
            {
                throw new ArgumentException("Age cannot be negative.");
            }
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
