using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Inheritance
{
    internal class Actor
    {
        public Actor(string name) { }

        public string Name { get; set; }

        public void AddName(string name) 
        {
            Name = name;
        }

    }
}
