using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Inheritance
{
    internal class MainActor : Actor
    {
        public MainActor(string name) : base(name) { }

        public void MoveInCamera() 
        {
            Console.WriteLine("카메라 안으로 신속 이동");
        }
    }
}
