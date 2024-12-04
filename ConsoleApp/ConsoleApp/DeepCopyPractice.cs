using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Inheritance;

namespace ConsoleApp
{
    internal class DeepCopyPractice
    {
        public void Main()
        {
            Console.WriteLine("\n\n\nDeepCopyPractice");


            Actor actor = new Actor("Man");
            Actor actor2 = actor.DeepCopy();
            Actor actor3 = actor.Clone() as Actor;

            actor = null;

            //Console.WriteLine(actor.Name);
            Console.WriteLine(actor2.Name);
            Console.WriteLine(actor3.Name);
        }
    }
}
