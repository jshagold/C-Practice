using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Inheritance;

namespace ConsoleApp
{
    internal class GenericPractice
    {
        public void Main()
        {
            Console.WriteLine("\n\n\nGeneric Practice");

            List<string> strings = new List<string>();
            List<int> ints = new List<int>();

            ActorManager actorManager = new ActorManager();
            actorManager.actorList.Add(new MainActor("JJin"));
            actorManager.actorList.Add(new MainActor("min"));
            actorManager.actorList.Add(new ExtraActor("ZZi"));
            actorManager.actorList.Add(new ExtraActor("ho"));
            actorManager.actorList.Add(new ExtraActor("siuuuuuu"));

            List<MainActor> mainActors = actorManager.GetMainActors();
            foreach (MainActor mainActor in mainActors)
            {
                Console.WriteLine(mainActor.Name);
            }

            List<ExtraActor> extraActors = actorManager.GetExtraActor();
            foreach (ExtraActor extraActor in extraActors)
                Console.WriteLine(extraActor.Name);


            List<MainActor> mainActors2 = actorManager.GetActors<MainActor>();
            foreach (MainActor mainActor2 in mainActors2)
            {
                Console.WriteLine($"mActor2: {mainActor2.Name}");
            }

            List<ExtraActor> exActor2 = actorManager.GetActors<ExtraActor>();
            foreach (ExtraActor exActor in exActor2)
            {
                Console.WriteLine($"exActor2: {exActor.Name}");
            }

            CameraManager<int> cameraManager = new CameraManager<int>();
            cameraManager.AddCameraInfo(1);
            cameraManager.AddCameraInfo(2);
            cameraManager.AddCameraInfo(3);

            CameraManager<string> cameraManager2 = new CameraManager<string>();
            cameraManager2.AddCameraInfo("Camera info: 1");
            cameraManager2.AddCameraInfo("Camera info: 2");
            cameraManager2.AddCameraInfo("Camera info: 3");


        }
    }
}
