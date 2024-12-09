using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Inheritance
{
    internal class Actor
    {
        public class Info
        {
            public int OptionType {  get; private set; }
            public int MoveDirection { get; private set; }

            public Info(int optionType, int moveDirection)
            {
                OptionType = optionType;
                MoveDirection = moveDirection;
            }
        }


        public Actor(string name) 
        { 
            Name = name;
        }

          
        public void SetInfo(Info info)
        {

        }

        public Actor DeepCopy()
        {
            Actor actor = new Actor(Name);
            actor.Description = this.Description;

            return actor;
        }

        public string Name { get; set; }
        public string Description { get; protected set; }

        public virtual void AddName(string name) 
        {
            Name = name;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
