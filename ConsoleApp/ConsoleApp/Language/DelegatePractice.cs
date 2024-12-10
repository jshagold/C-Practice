using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Language
{
    delegate void MyDelegate(string actorMessage);

    internal class DelegatePractice
    {
        public void Main()
        {
            Console.WriteLine("\n\n\n");

            MyDelegate cameraAction = CameraPickup;

            new ActorA().Action();
            new ActorB().Action(cameraAction);

        }


        class ActorA
        {
            public void Action()
            {
                Console.WriteLine("A Act");
            }
        }

        class ActorB
        {
            public void Action(MyDelegate handler)
            {
                Console.WriteLine("B Act");
                handler.Invoke("Action End!!");
            }
        }

        class Camera
        {
            public void PickupCamera()
            {
                Console.WriteLine("Camera Up!");
            }
        }

        static void CameraPickup(string message)
        {
            Camera camera = new Camera();
            camera.PickupCamera();
            Console.WriteLine(message);
        }


    }
}
