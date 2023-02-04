using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Student:Person
    {
        public string School { get; set; }
        public Student(string school)
        {
            School = school;
        }
        public Student(string name, string address) : base(name, address)
        {
        }

        public Student(string name, string address,string school) : base(name, address)
        {
            School=school;
        }
        public override void Print()
        {
            //cách 1: 
            base.Print();
            Console.WriteLine($"School: {School}");
            //cách 2: 
            //Console.WriteLine($"Name: {Name}, Address: {Address}, School: {School}");
        }

    }
}
