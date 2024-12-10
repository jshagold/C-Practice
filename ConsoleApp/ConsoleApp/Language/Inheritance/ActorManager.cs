using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Language.Inheritance
{
    internal class ActorManager
    {
        public List<Actor> actorList = new List<Actor>();

        private Actor boss;

        public ActorManager()
        {

        }

        public ActorManager(Actor boss)
        {
            this.boss = boss; ;
        }

        public void AddName(string value)
        {
            boss.AddName(value);
        }


        public List<MainActor> GetMainActors()
        {
            List<MainActor> actors = new List<MainActor>();

            foreach (Actor actor in actorList)
            {
                MainActor mainActor = actor as MainActor;
                if (mainActor != null)
                {
                    actors.Add(mainActor);
                }
            }
            return actors;
        }

        public List<ExtraActor> GetExtraActor()
        {
            List<ExtraActor> actors = new List<ExtraActor>();

            foreach (var actor in actorList)
            {
                ExtraActor exActor = actor as ExtraActor;
                if (exActor != null)
                    actors.Add(exActor);
            }

            return actors;
        }


        public List<T> GetActors<T>() where T : Actor
        {
            List<T> actors = new List<T>();

            foreach (Actor actor in actorList)
            {
                T rActor = actor as T;
                if (rActor != null)
                {
                    actors.Add(rActor);
                }
            }

            return actors;
        }
    }
}
