using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Language.Inheritance
{
    internal class DIProgram
    {
        private static int cameraCount = 10;

        public void Main()
        {
            Console.WriteLine("\n\n\n DI Program");
            // Dependency Injection, DI

            //ActorManager actorManager = new ActorManager(boss: new MainActor(name: Config.BOSS_NAME));


            CameraCount(cameraCount);
        }


        private static void CameraCount(int cameraCount)
        {
            Console.WriteLine(cameraCount);
        }

    }
}
