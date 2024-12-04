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


            IActor actor = new IActor("Man");
            IActor actor2 = actor.DeepCopy();
            IActor actor3 = actor.Clone() as IActor;

            actor = null;

            //Console.WriteLine(actor.Name);
            Console.WriteLine(actor2.Name);
            Console.WriteLine(actor3.Name);
        }
    }
}
