using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Inheritance
{
    internal class Program
    {
        public void Main()
        {
            Console.WriteLine("\n\n\n InheritancePractice");

            Actor extraActor = new ExtraActor("minsu");
            IActor mainActor = new MainActor("culsu");

            extraActor.AddName("Best");
            Console.WriteLine(extraActor);

            ExtraActor downCasting = extraActor as ExtraActor;
            downCasting?.MoveOffCamera();

            //extraActor.MoveOffCamera();
            //mainActor.MoveInCamera();

            ActorManager actorManager = new ActorManager(extraActor);
            actorManager.actorList.Add(extraActor);
            //actorManager.actorList.Add(mainActor);

            List<ExtraActor> actorList = actorManager.GetExtraActor();

            //List<Actor> actorList = new List<Actor>();
            //actorList.Add(mainActor);
            //actorList.Add(extraActor);

            //foreach (Actor actor in actorList)
            //{
            //    if (actor is ExtraActor)
            //    {
            //        ExtraActor exActor = (ExtraActor)actor;
            //        exActor.MoveOffCamera();
            //    }

            //    MainActor mActor = actor as MainActor;
            //    if (mActor != null)
            //    {
            //        mActor.MoveInCamera();
            //    }

            //}
        }
    }
}
