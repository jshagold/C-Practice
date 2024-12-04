using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Inheritance
{
    internal interface IActor
    {
        string Name { get; protected set; }
        string Description { get; protected set; }

        void AddName(string name);
    }
}
