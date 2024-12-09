using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Inheritance
{
    internal class SubActor : MainActor
    {
        public SubActor(string name) : base(name)
        {
        }

        public override void AddName(string name)
        {
            base.AddName(name);
        }
    }
}
