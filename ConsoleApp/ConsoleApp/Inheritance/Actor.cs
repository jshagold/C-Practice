using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Inheritance
{
    internal class Actor : ICloneable
    {
        public Actor(string name) 
        { 
            Name = name;
        }

        public Actor DeepCopy() 
        {
            Actor actor = new Actor(Name);
            actor.Description = this.Description;

            return actor;
        }

        public string Name { get; set; }
        public string Description { get; protected set; }

        public void AddName(string name) 
        {
            Name = name;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
