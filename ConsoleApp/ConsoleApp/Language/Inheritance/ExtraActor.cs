using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Language.Inheritance
{
    internal class ExtraActor : Actor
    {
        public ExtraActor(string name) : base(name) { }


        public void MoveOffCamera()
        {
            Console.WriteLine("카메라 밖으로 신속 이동");
        }

    }
}
