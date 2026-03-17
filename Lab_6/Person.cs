using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    abstract class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public abstract void Display();
    }
}
